using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB210156
{
    public class GradoviIB210156
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public int DrzavaId { get; set; }
        public DrzaveIB210156 drzava { get; set; }
    }
}
