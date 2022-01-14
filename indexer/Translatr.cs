using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    public class word
    {
        public string key { get; set; }
        public string value { get; set; }
        public word()
        {

        }
    }
    public class Dictionary
    {
        List<word> words;
        public Dictionary()
        {
            words = new();
        }
        public string this[string wrd] {
            
            get
            {
                foreach (var item in words)
                {
                    if (item.key == wrd) return item.value;
                }
                return "Soz tapilmadi";
            }

            
            set
            {
                foreach (var item in words)
                {
                    if (item.key == wrd)  item.value=value;
                }
            }
        }
        public void Addword(word t)
        {
            words.Add(t);
        }

    }
}
