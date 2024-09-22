using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManagment.Domia.Models
{
    public class TripModels
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string Until { get; set; }
        public int Qualification { get; set; }
        public DateTime ModifyDate { get; set; }
        public string UserCreate { get; set; }
        public bool Delete { get; set; }
        public bool UpDated { get; set; }
        public DateTime UpdaeData { get; set; } = DateTime.Now;
    }
}
