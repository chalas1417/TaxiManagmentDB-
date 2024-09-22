
using TaxiManagment.Domia.Base;

namespace TaxiManagment.Domia.Models
{
    public class TripDetailModels
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Latitude { get; set; }
        public decimal Legth { get; set; } = 0;
        public DateTime ModifyDate { get; set; }
        public string UserCreate { get; set; }
        public int TripId {  get; set; }
        public bool Delete { get; set; }
        public bool UpDated { get; set; }
        public DateTime UpdaeData { get; set; }

    }
}
