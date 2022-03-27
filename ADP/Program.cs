using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace APD
{
    class Program
    {
        private static List<char> headTabel = new List<char> { 'E', 'T', 'F', 'a', '+', '-','*',  '(', ')', '$' };
        private static List<char> neterminale = new List<char> { 'E', 'T', 'F' };
        private static List<char> semn = new List<char> { '+', '-', '*', '/' };
        private static List<List<string>> stivaAtribute = new List<List<string>> { new List<string> {}};
        private static List<string> codGenerat = new List<string>() { string.Empty };
        private static string strInput = string.Empty;
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary["E+T"] = "E";
            dictionary["T"] = "E";
            dictionary["E-T"] = "E";
            dictionary["T*F"] = "T";
            dictionary["F"] = "T";
            dictionary["a"] = "F";
            dictionary["(E)"] = "F";


            string[,] matrix = GetMatrix();

            for (int i = 0; i < headTabel.Count(); i++)
            {
                for (int j = 0; j < headTabel.Count(); j++)
                {
                    if (matrix[i, j] == null)
                    {
                        matrix[i, j] = "0";
                    }
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Stack<string> stack = APD(dictionary, matrix);
            var array = stack.ToArray();

            Console.Write("Numar:\t\t");
            Console.Write( "Stiva:\t\t");
            Console.Write("Stiva Atribute:\t\t");
            Console.Write("Cod Generat:");
            Console.WriteLine();

            for (int i=array.Length - 1; i>=0; i--)
            {
                if(array[i].Equals("Acceptat"))
                {
                    Console.WriteLine("\t\t Sir ACCEPTAT!");
                }
                else if(array[i].Equals("Error"))
                {
                    Console.WriteLine("\t\t Sir ERONAT!");
                }
                else
                {
                    Console.Write(array.Length - 1 - i + ". \t\t");
                    Console.Write(array[i] + "\t\t");
                    Console.Write(string.Join("", stivaAtribute[array.Length - 1 - i]) + "\t\t\t");
                    Console.Write(codGenerat[array.Length - 1 - i]);
                    Console.WriteLine();
                }

            }
            //while (stack.Count() > 0)
            //    Console.WriteLine(stack.Pop());
            Console.ReadLine();
        }

        private static Stack<string> APD(Dictionary<string, string> dictionary, string[,] matrix)
        {
            string reducere = ">.";
            List<string> deplasare = new List<string> { "<.", "=.", "=.(<.)" };
            string accept = "A.";

            Stack<string> stack = new Stack<string>();
            stack.Push("$");


            Console.WriteLine("Se introduce sirul de intrare: ");
                                   
            strInput = Console.ReadLine();
            
            int indexCodGenerat = 1;
            bool dog = false;

            while (!dog)
            {
                int index1, index2;

                string lastStackValue = stack.Peek();

                index1 = headTabel.FindIndex(c => c.Equals(strInput.ElementAt(0)));
                index2 = headTabel.FindIndex(c => c.Equals(lastStackValue.ElementAt(lastStackValue.Count() - 1)));

                string matrixValue = matrix[index2, index1];

                if (matrixValue.Equals(reducere))
                {
                    string substring = string.Empty;

                    if (lastStackValue.Count() > 3)
                    {
                        substring = lastStackValue.Substring(lastStackValue.Length - 3);

                        if (dictionary.TryGetValue(substring, out string value1))
                        {
                            lastStackValue = ReplaceLastOccurrence(lastStackValue, substring, value1);
                            stack.Push(lastStackValue);

                            var lastAtribute = new List<string>(stivaAtribute.Last());

                            if (semn.Contains(substring[1]))  //verifica daca stringul de 3 valori are sau nu semn.( "(E)" contraexemplu)
                            {
                                var codNouGenerat = "t" + indexCodGenerat; 
                                indexCodGenerat++;
                                

                                codGenerat.Add(codNouGenerat + " = " + lastAtribute[lastAtribute.Count - 2] + substring[1].ToString() + lastAtribute[lastAtribute.Count - 1]);
                                lastAtribute.RemoveRange(lastAtribute.Count - 2, 2);
                                lastAtribute.Add(codNouGenerat);
                                stivaAtribute.Add(lastAtribute);
                            }
                            else
                            {
                                stivaAtribute.Add(lastAtribute);
                                codGenerat.Add(string.Empty);
                            }
                            
                            continue;
                        }
                    }

                    substring = lastStackValue.Substring(lastStackValue.Length - 1);

                    if (dictionary.TryGetValue(substring, out string value2))
                    {
                        lastStackValue = ReplaceLastOccurrence(lastStackValue, substring, value2);
                        stack.Push(lastStackValue);
                        var lastAtribute = new List<string>(stivaAtribute.Last());
                        stivaAtribute.Add(lastAtribute);
                        codGenerat.Add(string.Empty);
                    }
                }
                else if (deplasare.Contains(matrixValue))
                {
                    stack.Push(lastStackValue + strInput.ElementAt(0));
                    List<string> newString = new List<string>(stivaAtribute.Last());

                    if (strInput.ElementAt(0).Equals('a'))
                    {
                        newString.Add("a");   //daca ultima valoarea de pe stiva este a atunci adaugam a in stiva atribute
                    }

                    stivaAtribute.Add(newString);  // daca nu pastram valoarea existenta 
                    codGenerat.Add(string.Empty);
                    strInput = strInput.Remove(0, 1);
                }
                else if (matrixValue.Equals(accept))
                {
                    stack.Push("Acceptat");
                    dog = true;
                }
                else if (matrixValue.Equals("0"))
                {
                    stack.Push("Error");
                    dog = true;
                }

            }

            return stack;
        }

        private static string ReplaceLastOccurrence(string sursa, string deInlocuit, string elementNou)
        {
            int place = sursa.LastIndexOf(deInlocuit);

            if (place == -1)
                return sursa;

            string result = sursa.Remove(place, deInlocuit.Length).Insert(place, elementNou);
            return result;
        }

        private static string[,] GetMatrix()
        {
            Dictionary<string, List<string>> productii = new Dictionary<string, List<string>>();
            productii.Add("E", new List<string> { "E+T", "T", "E-T"});
            productii.Add("T", new List<string> { "T*F", "F" });
            productii.Add("F", new List<string> { "a", "(E)"});
            productii.Add("S", new List<string> { "$E$" });

            Dictionary<string, List<char>> tiniuri = new Dictionary<string, List<char>>();
            Dictionary<string, List<char>> tfinuri = new Dictionary<string, List<char>>();
            foreach (var net in neterminale)
            {
                tiniuri.Add(net.ToString(), CreateTiniOrTfin(productii, net, true));
                tfinuri.Add(net.ToString(), CreateTiniOrTfin(productii, net, false));
            }
            return CreateMatrix(productii, tiniuri, tfinuri);
        }

        private static List<char> CreateTiniOrTfin(Dictionary<string, List<string>> productii, char neterminala, bool performTini)
        {
            List<char> neterminale = new List<char> { 'E', 'T', 'F' };
            List<char> terminale = new List<char>() { 'a', '+', '*', '(', ')','-', '/' };

            List<string> listaValori = new List<string>();

            for (int i = neterminale.IndexOf(neterminala); i < neterminale.Count(); i++)
            {
                listaValori.AddRange(productii[neterminale[i].ToString()]);
            }

            List<char> tiniSauTfin = new List<char>();

            foreach (var val in listaValori)
            {
                char indexValue;
                if (performTini)
                    indexValue = val[0];
                else
                    indexValue = val[val.Length - 1];

                if (neterminale.Contains(indexValue) || terminale.Contains(indexValue))
                {
                    if (!tiniSauTfin.Contains(indexValue))
                        tiniSauTfin.Add(indexValue);
                }
            }

            return tiniSauTfin;
        }
        private static string[,] CreateMatrix(Dictionary<string, List<string>> productii,
                                                    Dictionary<string, List<char>> tiniuri,
                                                    Dictionary<string, List<char>> tfinuri)
        {


            string[,] finalTable = new string[headTabel.Count(), headTabel.Count()];

            var start = productii["S"].First();
            finalTable[headTabel.IndexOf(start[0]), headTabel.IndexOf(start[1])] = "=.";
            finalTable[headTabel.IndexOf(start[1]), headTabel.IndexOf(start[2])] = "A.";

            AddToMatrix(tfinuri, headTabel, finalTable, new StringPair(start[1], start[2]), false);
            AddToMatrix(tiniuri, headTabel, finalTable, new StringPair(start[0], start[1]), true);

            foreach (var net in neterminale)
            {
                var listaProducti = productii[net.ToString()];

                foreach (var prod in listaProducti)
                {
                    if (prod.Length == 3)
                    {
                        finalTable[headTabel.IndexOf(prod[0]), headTabel.IndexOf(prod[1])] = "=.";
                        finalTable[headTabel.IndexOf(prod[1]), headTabel.IndexOf(prod[2])] = "=.";
                        if (prod.Where(a => neterminale.Contains(a)).Count() == 1)
                        {
                            AddToMatrix(tfinuri, headTabel, finalTable, new StringPair(prod[1], prod[2]), false);
                            AddToMatrix(tiniuri, headTabel, finalTable, new StringPair(prod[0], prod[1]), true);
                        }
                        else
                        {
                            AddToMatrix(tfinuri, headTabel, finalTable, new StringPair(prod[0], prod[1]), false);
                            AddToMatrix(tiniuri, headTabel, finalTable, new StringPair(prod[1], prod[2]), true);
                        }
                    }
                }
            }

            return finalTable;
        }

        private static void AddToMatrix(Dictionary<string, List<char>> tiniuriSauTfinuri, List<char> headTabel, string[,] finalTable, StringPair initialPair, bool isTini)
        {
            var pairslist = new List<StringPair>();
            var listaDeValori = new List<char>();
            char terminalKey;

            if (tiniuriSauTfinuri.ContainsKey(initialPair.First.ToString()))
            {
                tiniuriSauTfinuri.TryGetValue(initialPair.First.ToString(), out listaDeValori);
                terminalKey = initialPair.Second;
            }
            else
            {
                tiniuriSauTfinuri.TryGetValue(initialPair.Second.ToString(), out listaDeValori);
                terminalKey = initialPair.First;
            }

            if (isTini)
            {
                foreach (var val in listaDeValori)
                {
                    pairslist.Add(new StringPair(terminalKey, val, "<."));
                }
            }
            else
            {
                foreach (var val in listaDeValori)
                {
                    pairslist.Add(new StringPair(val, terminalKey, ">."));
                }
            }

            foreach (var pair in pairslist)
            {
                if (finalTable[headTabel.IndexOf(pair.First), headTabel.IndexOf(pair.Second)] != null)
                    finalTable[headTabel.IndexOf(pair.First), headTabel.IndexOf(pair.Second)] = finalTable[headTabel.IndexOf(pair.First), headTabel.IndexOf(pair.Second)] + "(" + pair.Symbol + ")";
                else
                    finalTable[headTabel.IndexOf(pair.First), headTabel.IndexOf(pair.Second)] = pair.Symbol;
            }
        }


    }

    public class StringPair
    {
        public StringPair(char first, char second, string symbol)
        {
            First = first;
            Second = second;
            Symbol = symbol;
        }

        public StringPair(char first, char second)
        {
            First = first;
            Second = second;
        }

        public char First { get; }
        public char Second { get; }
        public string Symbol { get; }
    }
}