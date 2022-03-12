using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Regasirea_Informatiei
{
    /// <summary>
    /// Parse
    /// - Titlu
    /// - paragrafele
    /// - cod topics
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:/Coding/Regasirea Informatiei/XML/Reuters_34/2504NEWS.XML");

            XmlNodeList nodes = xmlDoc.SelectNodes("//newsitem");            


            foreach (XmlNode node in nodes)
            {
                XmlNode title = node.SelectSingleNode("//title[1]/text()[1]");
                if (title != null)
                {
                    Console.WriteLine(title.InnerText);
                }
                XmlNode text = node.SelectSingleNode("//text[1]");
                if(text != null)
                {
                    Console.WriteLine(text.InnerText);
                }
                XmlNode topics = node.SelectSingleNode("//codes[@class='bip:topics:1.0'][1]/@class");
                if(topics != null)
                {
                    Console.WriteLine(topics.InnerText);
                }
                
            }            

        }       
    }
}
