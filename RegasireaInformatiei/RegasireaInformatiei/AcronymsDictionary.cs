using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegasireaInformatiei
{
    public class AcronymsDictionary
    {
        private readonly string path;
        Dictionary<string,string> acronyms = new Dictionary<string,string>();

        public AcronymsDictionary(string path)
        {
            this.path = path;
            LoadDictionary();
        }

        private void LoadDictionary()
        {
            List<string> acronymsList = File.ReadAllLines(this.path).ToList();
            for (int i = 0; i < acronymsList.Count; i++)
            {
                var split = acronymsList[i].Split(',');
                acronyms[split[0]] = split[1];
           
            }
        }
        public string GetAcronyms(string text)
        {
            string description = string.Empty;
            acronyms.TryGetValue(text, out description);
            return description;
        }
    }
}
