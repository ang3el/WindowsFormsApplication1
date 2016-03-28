using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Lista
    {
        public string ime  { get; set; }
        public string prezime { get; set; }
        public string oib { get; set; }
        public Lista()
        {
            
        }
        
        public void unos(string i, string p, string o)
        {
            ime = i;
            prezime = p;
            oib = o;
        }
        public string ispis()
        {
            string osobe ="";
            osobe = ime + " " + prezime + " "+ oib + "\r\n";
            return osobe;
            
        }
    }
}
