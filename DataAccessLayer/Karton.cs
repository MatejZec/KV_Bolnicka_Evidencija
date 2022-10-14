using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Karton
    {
        public int Id { get; set; }
        public string PacijentId { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
        public string Dijagnoza { get; set; }
        public string Status { get; set; }
        public string Preporuka { get; set; }
    }
}
