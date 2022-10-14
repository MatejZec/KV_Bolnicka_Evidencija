using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Pacijent
    {
        public string MBO { get; set; }
        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DOB { get; set; }
        public string Spol { get; set; }
        public string Kontakt { get; set; }

    }
}
