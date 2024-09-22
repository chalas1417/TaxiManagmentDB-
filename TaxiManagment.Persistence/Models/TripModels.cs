using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManagment.Persistence.Models
{
    public class TripModels
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string Until { get; set; }
        public int Qualification { get; set; }
    }
}
