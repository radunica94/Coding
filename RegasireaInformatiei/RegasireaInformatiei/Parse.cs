using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
            article.AddRange(ReplaceAcronyms(titles));
            article.AddRange(ReplaceAcronyms(texts));
            for(int i = 0; i < article.Count; i++)
            {               
                Console.WriteLine(article[i]);                
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
            List<string> acronyms = File.ReadAllLines("C:\\Coding\\RegasireaInformatiei\\RegasireaInformatiei\\acronime.txt").ToList();
            
            for(int i = 0; i < text.Count; i++)
            {
                for(int j = 0; j < acronyms.Count; j++)
                {
                    if (text[i].Equals(acronyms[0].First()))
                    {
                        text[i] = text[i].Replace(" " + acronyms[0] + ",", acronyms[1]);
                    }
                }
            }
            return null;
        }
        private static List<string> FilterWords(string str)
        {
            var upper = str.Split(' ').Where(s=> String.Equals(s,s.ToUpper(),StringComparison.Ordinal));

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
