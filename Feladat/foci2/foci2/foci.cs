using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foci2
{
    internal class foci
    {
        public foci(int fordulo, int hazaigol, int vendeggol, int hazaifelido, int vendegfelido, string hazainev, string vendegnev)
        {
            Fordulo = fordulo;
            Hazaigol = hazaigol;
            Vendeggol = vendeggol;
            Hazaifelido = hazaifelido;
            Vendegfelido = vendegfelido;
            Hazainev = hazainev;
            Vendegnev = vendegnev;
        }

        public int Fordulo {  get; set; }
        public int Hazaigol { get; set; }
        public int Vendeggol { get; set; }
        public int Hazaifelido { get; set; }
        public int Vendegfelido { get; set; }
        public string Hazainev  { get; set; }
        public string Vendegnev { get; set; }
    }
    
    
}
