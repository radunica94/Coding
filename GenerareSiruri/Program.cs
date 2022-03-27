using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GenerareSiruri
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\documente\CSharp\CSharp2021\GenerareSiruri\GenerareSiruri.txt";

            string[] lines = File.ReadAllLines(filePath);

            

            string neterminale = string.Empty;
            string terminale = string.Empty;
            string simbolStart = string.Empty;
            string productie = string.Empty;

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            foreach (string line in lines)
            {
                if (line.StartsWith("N") )
                {
                    var textN = line.Replace("N=","");     
                   neterminale = textN.Trim();                                                    
                }
                if(line.StartsWith("Term"))
                {
                    var textT = line.Replace("Term=", "");
                    terminale = textT.Trim();
                }
                if (line.StartsWith("S"))
                {
                    var textS = line.Replace("S=", "");
                    simbolStart = textS.Trim();
                }
                if (line.StartsWith("P"))
                {
                    var textP = line.Replace("P=", "");
                    productie = textP.Trim();
                }


            }
            string[] splitNeterminaleArray = neterminale.Split(new char[] { '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string splitN in splitNeterminaleArray)
            {
                dictionary.Add(splitN, null);
            }
            string[] splitTerminaleArray = terminale.Split(new char[] { '{', ',', '}' }, StringSplitOptions.RemoveEmptyEntries);
            char[] caractereTerminale = new char[splitTerminaleArray.Length];
            for(int i = 0; i< splitTerminaleArray.Length; i++)
            {
                caractereTerminale[i] = Char.Parse(splitTerminaleArray[i].Trim());
            }

            string[] splitSimbolStarArray = simbolStart.Split(new char[] { '{', ',', '}' }, StringSplitOptions.RemoveEmptyEntries);


            string splitProd = productie;
            string[] productieArray = splitProd.Split(new char[] { '{', ',', '}' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string splitP in productieArray)
            {
                string[] valProd = splitP.Split('=', '|');

                List<string> listaProductie = new List<string>();
                listaProductie.Add(valProd[1]);
                listaProductie.Add(valProd[2]);
                

                if(dictionary.ContainsKey(valProd[0]))
                {
                    dictionary[valProd[0]] = listaProductie;
                }
                else
                {
                    dictionary.Add(valProd[0], listaProductie);
                }                
            }

            var productii = dictionary[splitSimbolStarArray[0]];
            string stringFinal = splitSimbolStarArray[0] + " = ";            
            

            Random random = new Random();
            var randomNumber = random.Next(2);
            var lastString = productii[randomNumber];
            stringFinal += lastString;

            //split la ultimul string pentru a verifica daca are elemente neterminale sau nu
            var split = lastString.Split(caractereTerminale, StringSplitOptions.RemoveEmptyEntries);
            var elementDreapta = string.Empty;


            //verificam daca stringul are elemente neterminale
            if (split.Any())
            {
                elementDreapta = split.Last();
                //elementDreapta = split.First();
                productii = dictionary[elementDreapta];
            }
            //daca nu are , afiseaza stringul final
            else
            {
                Console.WriteLine(stringFinal);
                Console.ReadLine();
            }

            while (true)
            {
                var gata = ConditieTerminare(splitTerminaleArray, lastString);
                if (gata)
                {
                    break;
                }

                randomNumber = random.Next(2);
                var productieNoua = productii[randomNumber];
                lastString = ReplaceLastOccurrence(lastString, elementDreapta, productieNoua);
                stringFinal += " = " + lastString;

                var elemente = lastString.Split(caractereTerminale, StringSplitOptions.RemoveEmptyEntries);
                
                if(elemente.Any())
                {             
                    elementDreapta = elemente.Last();
                    //elementDreapta = elemente.First();
                    productii = dictionary[elementDreapta];
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(stringFinal);                        

            Console.ReadLine();

        }

        
        private static string ReplaceLastOccurrence(string sursa, string deInlocuit, string elementNou)
        {
            int place = sursa.LastIndexOf(deInlocuit);
            //int place = sursa.IndexOf(deInlocuit);

            if (place == -1)
                return sursa;

            string result = sursa.Remove(place, deInlocuit.Length).Insert(place, elementNou);
            return result;
        }

        
        private static bool ConditieTerminare(string[] splitTerminaleArray, string lastString)
        {
            int i = 0;

            if (lastString.Length > 60)
            {
                return true;
            }
            foreach (var stringChar in lastString)
            {
                if (splitTerminaleArray.Contains(stringChar.ToString()))
                {
                    i++;
                }
            }
            if (i == lastString.Length)
            {
                return true;
            }

            return false;
        }
    }
}
