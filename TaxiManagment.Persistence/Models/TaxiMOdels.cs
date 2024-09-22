using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManagment.Persistence.Models
{
   public class TaxiMOdels
    {
        public int Id { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime StarEnd { get; set; }
        public string Until { get; set; }
        public decimal Qualification { get; set; }
    }
}
