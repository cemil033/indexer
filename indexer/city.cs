using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    public class City
    {
        public int Ehalisayi { get; set; }
        public static bool operator==(City a,City b)
        {
            return a.Ehalisayi == b.Ehalisayi;
        }
        public static bool operator !=(City a, City b)
        {
            return a.Ehalisayi != b.Ehalisayi;
        }
        public override bool Equals(object obj)
        {
            if (obj is World.City)
            {
                return this.Ehalisayi == (obj as City).Ehalisayi;
            }
            else return false;
        }
    }
    
}

