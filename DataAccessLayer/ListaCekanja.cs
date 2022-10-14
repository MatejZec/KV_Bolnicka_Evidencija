using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ListaCekanja
    {
        public int Id { get; set; }
        public string Pacijent_Id { get; set; }
        public DateTime Zakazano { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
