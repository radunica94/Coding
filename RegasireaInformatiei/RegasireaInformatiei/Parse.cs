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
            string PathFile = @"C:\\Coding\\RegasireaInformatiei\\RegasireaInformatiei\\Output8.txt";

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
                var code = xmlDocuments[i].SelectNodes("//codes[@class='bip:topics:1.0']//code/@code");
                string codeNames = string.Empty;
                foreach (XmlNode node in code)
                {
                    codeNames += (node.InnerText) + " ";
                }
                codes.Add(codeNames);
            }

            titles = RemoveSymbols(titles);
            texts = RemoveSymbols(texts);
            //Pentru afisarea unei liste care contine acronimele
            acronimList.AddRange(Acronime(titles));
            acronimList.AddRange(Acronime(texts));
            StopWords(texts);
            // Pentru afisarea unei liste de articole care contine titlul + textul

            titles = LowerCase(ReplaceAcronyms(titles));
            texts = LowerCase(ReplaceAcronyms(texts));

            // Unique words
            // Save unique words in a txt file
            uniqueWords.AddRange(titles);
            uniqueWords.AddRange(texts);


            steamsTitles.AddRange(GetStems(StopWords(titles)));
            steamsTexts.AddRange(GetStems(StopWords(texts)));

            steams.AddRange(steamsTitles);
            steams.AddRange(steamsTexts);

            var words = GetUniqueWords(steams);
            var uniqueWordsCount = new Dictionary<string, List<Cuvant>>();
            
           if (!File.Exists(PathFile))
           {
                using(StreamWriter sw  = File.CreateText(PathFile))
                {
                    foreach (var word in words)
                    {
                        sw.WriteLine("@Attribute " + word);
                    }

                    uniqueWordsCount = GetUniqueWordsCount(steamsTitles, steamsTexts, words);
                    

                    sw.WriteLine("\n" + "@Data : ");
                    for (int i = 0; i < fileNames.Count; i++)
                    {
                        sw.Write("\n" + fileNames[i] + "  #  ");
                        for (int j = 0; j < words.Count; j++)
                        {
                            var count = uniqueWordsCount[fileNames[i]].Find(c => c.Index == j);
                            if (count != null)
                            {
                                sw.Write(j + ":" + count.Repetitions + "  ");                                
                            }
                        }
                        sw.Write(" # " + codes[i]);
                    }
                }
           }

            var normalizedDictionary = NormalizeDictionary(uniqueWordsCount, words.Count);

            //var documentsContainWord = DocumentsContainsWord(GetWordindex(words, "unit"), normalizedDictionary);
            var stringToCompare = GetUniqueWordsCountQuestion(GetStems(StopWords(LowerCase(ReplaceAcronyms(RemoveSymbols(new List<string>{ Console.ReadLine() }))))).First(), words);
            EuclidianDistance(normalizedDictionary, stringToCompare, words);


            Console.WriteLine("DONE");
                  
            Console.ReadLine();
        }

        private static void EuclidianDistance(Dictionary<string, List<Cuvant>> texts, Dictionary<string, List<Cuvant>> stringToCompare, List<string> words)
        {
            foreach (var key in stringToCompare.Keys)
            {
                var sum = GetTotalWordCount(stringToCompare[key]);

                foreach (var cuvant in stringToCompare[key])
                {
                    cuvant.Repetitions = (cuvant.Repetitions / sum) * (double)Math.Log((double)texts.Count / DocumentsContainWord(cuvant.Index, texts));
                }
            }

            foreach (var key in texts.Keys)
            {
                var sum = GetTotalWordCount(texts[key]);

                foreach (var cuvant in texts[key])
                {
                    cuvant.Repetitions = (cuvant.Repetitions / sum) * (double)Math.Log((double)texts.Count / DocumentsContainWord(cuvant.Index, texts));
                }
            }

            var cuvinteNoi = stringToCompare["Question"];

            var x = new List<Euclidian>();

            foreach(var key in texts.Keys)
            {
                double powerSum = 0;
                for(int i=0; i< cuvinteNoi.Count; i++)
                {
                    var cuvinte = texts[key];
                    powerSum += Math.Pow(cuvinteNoi[i].Repetitions - cuvinte[i].Repetitions, 2);
                }
                var distance = Math.Sqrt(powerSum);
                x.Add(new Euclidian(key, distance));
                //sqrt( (q1-d1)^2 + (q  2-d2)^2 + ..... +(qn-dn)^2)

            }

            var y = x.OrderByDescending(d => d.Sum).ToArray();

            for(int i=0; i<5; i++)
            {
                var aa = y[0];
                Console.WriteLine(i + 1 + aa.Name + " : " + aa.Sum);

            }
        }


        public static double GetTotalWordCount(List<Cuvant> cuvinte)
        {
            double count = 0;
            foreach(var cuvant in cuvinte)
            {
                count += cuvant.Repetitions;
            }

            return count;
        }

        private static double DocumentsContainWord(int wordIndex, Dictionary<string, List<Cuvant>> texts)
        {
            double count = 0;

            if(wordIndex < 0)
            {
                return 1;
            }

            foreach (var key in texts.Keys)
            {
                var cuvinte = texts[key];

                foreach(var cuvant in cuvinte)
                {
                    if(cuvant.Index == wordIndex)
                    {
                        if(cuvant.Repetitions > 0)
                        {
                            count++;
                            break;
                        }
                    }
                }
            }
            return count;
        }

        private static Dictionary<string, List<Cuvant>> NormalizeDictionary(Dictionary<string, List<Cuvant>> dictionary, int wordsCount)
        {
            var normalizedDictionary = new Dictionary<string, List<Cuvant>>();
            
            foreach (var key in dictionary.Keys)
            {
                normalizedDictionary.Add(key, NormalizeStringList(dictionary[key], wordsCount));
            }
            
            return normalizedDictionary;
        }

        private static List<Cuvant> NormalizeStringList(List<Cuvant> cuvinte, int wordCount)
        {
            List<Cuvant> cuvinteNormalizate = new List<Cuvant>();
            int counter = 0;
            
            for(int i=0; i < wordCount; i++)
            {
                if(cuvinte.Count > counter && cuvinte[counter].Index == i)
                {
                    cuvinteNormalizate.Add(new Cuvant(i, cuvinte[counter].Repetitions));
                    counter++;
                }
                else
                {
                    cuvinteNormalizate.Add(new Cuvant(i, 0));   
                }
            }

            return cuvinteNormalizate;
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


        // parse after 's 
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

        public static Dictionary<string, List<Cuvant>> GetUniqueWordsCountQuestion(string text, List<string> words)
        {
            Dictionary<string, List<Cuvant>> articole = new Dictionary<string, List<Cuvant>>();
            var uniqueWords = new List<string>();

            var split = (text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList());
            List<Cuvant> cuvinte = new List<Cuvant>();

            for (int j = 0; j < words.Count(); j++)
            {
                var count = split.Count(s => string.Equals(s, words[j]));
                if (count > 0)
                {
                    cuvinte.Add(new Cuvant(j, count));
                }
            }
            articole.Add("Question", cuvinte);

            return articole;
        }

        public static Dictionary<string, List<Cuvant>> GetUniqueWordsCount(List<string> titles, List<string> texts, List<string> words)
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
            }
            return articole;
        }


    }
}
