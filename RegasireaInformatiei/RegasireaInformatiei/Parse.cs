using Annytab.Stemmer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace RegasireaInformatiei
{
    public class Parse   
    {
        private static List<string> fileNames;

        static public void Main(String[] args)
        {
            List<string> xmlPaths = Directory.GetFiles("C:\\Coding\\RegasireaInformatiei\\RegasireaInformatiei\\XML\\Reuters_34").ToList();
            fileNames = xmlPaths.Select(a => Path.GetFileName(a)).ToList();
            List<XmlDocument> xmlDocuments = new List<XmlDocument>();
            string PathFile = @"C:\\Coding\\RegasireaInformatiei\\RegasireaInformatiei\\Output.txt";

            foreach (string xmlPath in xmlPaths)
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(xmlPath);
                xmlDocuments.Add(xmlDocument);
            }

            List<string> titles = new List<string>();
            List<string> texts = new List<string>();
            List<string> codes = new List<string>();
            List<string> acronimList = new List<string>();
            List<string> uniqueWords = new List<string>();
            List<string> steamsTitles = new List<string>();
            List<string> steamsTexts = new List<string>();
            List<string> steams = new List<string>();
            for (int i = 0; i < xmlDocuments.Count; i++)
            {
                titles.Add(xmlDocuments[i].GetElementsByTagName("title")[0].InnerText);
                texts.Add(xmlDocuments[i].GetElementsByTagName("text")[0].InnerText);
                //codes.Add(xmlDocuments[i].SelectSingleNode("//codes[@class='bip:topics:1.0']"));
                var code = xmlDocuments[i].SelectNodes("//codes[@class='bip:topics:1.0']//code/@code");
                string codeNames = string.Empty;
                foreach (XmlNode node in code)
                {
                    codeNames += (node.InnerText) + " ";
                    //Console.WriteLine(node.InnerText);
                }
                codes.Add(codeNames);
            }

            titles = RemoveSymbols(titles);
            texts = RemoveSymbols(texts);
            //Pentru afisarea unei liste care contine acronimele
            acronimList.AddRange(Acronime(titles));
            acronimList.AddRange(Acronime(texts));
            //for (int i = 0; i < acronimList.Count; i++)
            //{
            //    Console.WriteLine(acronimList[i]);
            //}
            StopWords(texts);
            // Pentru afisarea unei liste de articole care contine titlul + textul

            titles = LowerCase(ReplaceAcronyms(titles));
            texts = LowerCase(ReplaceAcronyms(texts));
            //for (int i = 0; i < titles.Count; i++)
            //{
            //    Console.WriteLine("Article " + i + ":\n");
            //    Console.WriteLine(titles[i] + "\n");
            //    Console.WriteLine(texts[i] + "\n\n\n");
            //}

            // Unique words
            // Save unique words in a txt file
            uniqueWords.AddRange(titles);
            uniqueWords.AddRange(texts);


            steamsTitles.AddRange(GetStems(StopWords(titles)));
            steamsTexts.AddRange(GetStems(StopWords(texts)));

            steams.AddRange(steamsTitles);
            steams.AddRange(steamsTexts);

            var words = GetUniqueWords(steams);

           if(!File.Exists(PathFile))
           {
                using(StreamWriter sw  = File.CreateText(PathFile))
                {
                    foreach (var word in words)
                    {
                        sw.WriteLine("@Attribute " + word);
                    }

                    var uniqueWords2 = GetUniqueWords2(steamsTitles, steamsTexts, words);


                    sw.WriteLine("\n" + "@Data : ");
                    for (int i = 0; i < fileNames.Count; i++)
                    {
                        sw.Write("\n" + fileNames[i] + "  #  ");
                        for (int j = 0; j < words.Count; j++)
                        {
                            var count = uniqueWords2[fileNames[i]].Find(c => c.Index == j);
                            if (count != null)
                            {
                                sw.Write(j + ":" + count.Repetitions + "  ");                                
                            }
                        }
                        sw.Write(" # " + codes[i]);
                    }
                }
           }

            Console.WriteLine("DONE");

            Console.ReadLine();
        }

        public static List<string> RemoveSymbols(List<string> texts)
        {
            List<char> chars = new List<char>() { '.', ',', '(', ')', '-', '"', ':' ,'*' };
            for(int i = 0; i<texts.Count; i++)
            {
                foreach(var character in chars)
                {
                    texts[i] = texts[i].Replace(character, ' ');
                }
            }
            return texts;
        }

        public static List<string> GetUniqueWords(List<string> texts)
        {
            List<string> words = new List<string>();

            foreach (var text in texts)
            {
                var words2 = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var word in words2)
                {
                    if (!words.Contains(word))
                    {
                        words.Add(word);
                    }
                }
            }

            return words;
        }
        
        private static List<string> GetStems(List<string> text)
        {
            List<string> newText = new List<string>();
            for(int i=0; i<text.Count; i++)
            {
                var words = text[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach(var word in words)
                {
                    var x = new EnglishStemmer();
                    var stem = x.GetSteamWord(word);
                    if (!string.IsNullOrEmpty(stem))
                    {
                        text[i] = text[i].Replace(word, stem);
                    }
                }
            }
            return text;
        }
        
        private static List<string> Acronime(List<string> text)
        {
            var acronime = new List<string>();
            foreach (var a in text)
            {
                acronime.AddRange(FilterWords(a));
            }                     

            return acronime;
        }

             
        private static List<string> ReplaceAcronyms(List<string> text)
        {
            var x = new AcronymsDictionary("C:\\Coding\\RegasireaInformatiei\\RegasireaInformatiei\\acronime.txt");
            //x.GetValue("USA");
            for(int i = 0; i < text.Count; i++)
            {
                var filtered = FilterWords(text[i]);
                if(filtered != null && filtered.Any())
                {
                    foreach(var acronym in filtered)
                    {
                        var value = x.GetAcronyms(acronym);
                        if(value != null && value != string.Empty)
                        {
                            text[i] = text[i].Replace(acronym, value);
                        }
                    }
                }
            }            
            return text;
        }       
        

        private static List<string> LowerCase(List<string> text)
        {
            List<string> lowerCase = new List<string>();
            for (int i = 0; i < text.Count; i++)
            {
                lowerCase.Add(text[i].ToLower());
            }
            return lowerCase;
        }
        private static List<string> FilterWords(string str)
        {
            var split = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var upper = split.Where(s=> String.Equals(s,s.ToUpper(),StringComparison.Ordinal)).ToList();
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            upper = upper.Select(s => rgx.Replace(s, "")).ToList();
            Regex rgx2 = new Regex(@"\b[a-zA-Z]{3}\.*\:*\ {1}");
            var x = rgx2.Matches(str).Cast<Match>().Select(m => m.Value.TrimEnd()).ToList();
            upper.AddRange(x);
            return upper;
        }

        private static List<string> StopWords(List<string> texts)
        {
            List<string> stopWords = File.ReadAllLines("C:\\Coding\\RegasireaInformatiei\\RegasireaInformatiei\\stopwordList.txt").ToList();
            for(int i = 0; i < texts.Count; i++)
            {
                for(int j = 0; j < stopWords.Count; j++)
                {
                    texts[i] = texts[i].Replace(" " + stopWords[j] + " ", " ");
                }
            }            
            return texts;
        }

        public static Dictionary<string, List<Cuvant>> GetUniqueWords2(List<string> titles, List<string> texts, List<string> words)
        {
            Dictionary<string, List<Cuvant>> articole = new Dictionary<string, List<Cuvant>>();
            var uniqueWords = new List<string>();

            for (int i = 0; i < fileNames.Count; i++)
            {
                var split = titles[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                split.AddRange(texts[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList());
                List<Cuvant> cuvinte = new List<Cuvant>();

                for(int j=0; j< words.Count(); j++)
                {
                    var count = split.Count(s => string.Equals(s, words[j]));
                    if(count > 0)
                    {
                        cuvinte.Add(new Cuvant(j, count));
                    }
                }
                articole.Add(fileNames[i], cuvinte);

                //foreach (string word in split)
                //{
                //    if (articole.ContainsKey(fileNames[i]))
                //    {
                //        articole.TryGetValue(word, out List<Cuvant> articol);
                //        var x = articol.Where(a => a.Index == i);
                //        if (x.Any())
                //        {
                //            x.Count();
                //        }
                //        else
                //        {

                //        }
                //        articole[word].Add(new Cuvant(i, 0));
                //    }
                //    else
                //    {
                //        articole.Add(word, new List<Cuvant>());
                //        articole[word].Add(new Cuvant(i, 1));
                //    }
                //    if (text[i].Contains(word)) { uniqueWords.Add(word); break; }
                //}
            }
            return articole;
        }


    }
}
