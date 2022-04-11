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
    public class Parse   {


        static public void Main(String[] args)
        {

            List<string> xmlPaths = Directory.GetFiles("C:\\Coding\\RegasireaInformatiei\\RegasireaInformatiei\\XML\\Reuters_34").ToList();
            List<XmlDocument> xmlDocuments = new List<XmlDocument>();

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
            List<string> steams = new List<string>();

            for (int i = 0; i < xmlDocuments.Count; i++)
            {
                titles.Add(xmlDocuments[i].GetElementsByTagName("title")[0].InnerText);
                texts.Add(xmlDocuments[i].GetElementsByTagName("text")[0].InnerText);
                //codes.Add(xmlDocuments[i].SelectSingleNode("//codes[@class='bip:topics:1.0']"));
                var code = xmlDocuments[i].SelectNodes("//codes[@class='bip:topics:1.0']//code/@code");
                foreach (XmlNode node in code)
                {
                    //Console.WriteLine(node.InnerText);
                }
            }
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

            steams.AddRange(GetStems(StopWords(titles)));
            steams.AddRange(GetStems(StopWords(texts)));
            
            
            GetUniqueWords(uniqueWords);


            List<string> output = GetUniqueWords(uniqueWords);
            //for (int i = 0; i < output.Count; i++)
            //{
            //    Console.WriteLine(output[i]);
            //}

            // Stemmer
           



            Console.ReadLine();
        }
        
        private static List<string> GetStems(List<string> text)
        {
            foreach (var line in text)
            {
                var words = line.Split(' ').ToList();
                foreach(var word in words)
                {
                    var x = new EnglishStemmer();
                    var stem = x.GetSteamWord(word);
                    if (!string.IsNullOrEmpty(stem))
                    {
                        line.Replace(word, stem);
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
            var split = str.Split(' ');
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
       
        public static List<string> GetUniqueWords(List<string> text)
        {
            Dictionary<string, List<Articol>> articole = new Dictionary<string, List<Articol>>();
            var uniqueWords = new List<string>();    
            
            for(int i = 0; i < text.Count; i++)
            {
                var split = text[i].Split(' ');
                foreach(string word in split)
                {
                    if (articole.ContainsKey(word))
                    {
                        articole.TryGetValue(word, out List<Articol> articol);
                        var x = articol.Where(a => a.Index == i);
                        if (x.Any())
                        {
                            x.Count();
                        }
                        else
                        {
                            
                        }
                        articole[word].Add(new Articol(i, 0));
                    }
                    else
                    {
                        articole.Add(word, new List<Articol>());
                        articole[word].Add(new Articol(i, word));
                    }
                    if (text[i].Contains(word)) { uniqueWords.Add(word); break; }
                }
            }
            return text;
        }            

    }
}
