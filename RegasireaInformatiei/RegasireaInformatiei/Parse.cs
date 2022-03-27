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
            List<string> article = new List<string>();
            for(int i = 0; i < xmlDocuments.Count; i++)
            {
                titles.Add(xmlDocuments[i].GetElementsByTagName("title")[0].InnerText);
                texts.Add(xmlDocuments[i].GetElementsByTagName("text")[0].InnerText);
                //codes.Add(xmlDocuments[i].SelectSingleNode("//codes[@class='bip:topics:1.0']"));
                var code = xmlDocuments[i].SelectNodes("//codes[@class='bip:topics:1.0']//code/@code");
                foreach(XmlNode node in code)
                {
                    //Console.WriteLine(node.InnerText);
                }                
            }
            //Pentru afisarea unei liste care contine acronimele
            acronimList.AddRange(Acronime(titles));
            acronimList.AddRange(Acronime(texts));
            for(int i = 0; i < acronimList.Count; i++)
            {
                //Console.WriteLine(acronimList[i]);                 
            }
            StopWords(texts);
            // Pentru afisarea unei liste de articole care contine titlul + textul
            titles = LowerCase(ReplaceAcronyms(titles));
            texts = LowerCase(ReplaceAcronyms(texts));
            for(int i = 0; i < titles.Count; i++)
            {
                Console.WriteLine("Article " + i + ":\n");
                Console.WriteLine(titles[i]+"\n");
                Console.WriteLine(texts[i] + "\n\n\n");                
            }
            
            Console.ReadLine();
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
            var upper = str.Split(' ').Where(s=> String.Equals(s,s.ToUpper(),StringComparison.Ordinal));
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            upper = upper.Select(s=> rgx.Replace(s, ""));
            return upper.ToList();
        }
        private static string StopWords(List<string> texts)
        {
            List<string> stopWords = File.ReadAllLines("C:\\Coding\\RegasireaInformatiei\\RegasireaInformatiei\\stopwordList.txt").ToList();
            for(int i = 0; i < texts.Count; i++)
            {
                for(int j = 0; j < stopWords.Count; j++)
                {
                    texts[i] = texts[i].Replace(" " + stopWords[j] + " ", " ");
                }
                //Console.WriteLine(texts[i]);
            }            
            return null;
        }

        //TODO - pentru acronime , foloseste regex pentru a gasi literele mari
        //TODO - afiseaza toate cu litere meci, text si tiltlu
    }
}
