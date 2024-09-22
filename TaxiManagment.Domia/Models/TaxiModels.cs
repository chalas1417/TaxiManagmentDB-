

namespace TaxiManagment.Domia.Models
{
    public class TaxiModels
    {
        public  int Id { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime StarEnd { get; set; }
        public string Until { get; set; }
        public int TripDetailId {  get; set; }
        public DateTime ModifyDate { get; set; }
        public string UserCreate {  get; set; }
        public bool Delete { get; set; }
        public bool UpDated { get; set; }
        public DateTime UpdaeData { get; set; }
    }

}
