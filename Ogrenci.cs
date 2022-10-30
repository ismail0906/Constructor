using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructor
{
    public class Ogrenci
    {
        public Ogrenci(string isim)
        {
            Adi = isim;

        }
        public Ogrenci()
        {

        }

        public string Adi { get; set; }
        public string SoyAdi { get; set; }



        ~Ogrenci() 
        {
        }
    }
}
