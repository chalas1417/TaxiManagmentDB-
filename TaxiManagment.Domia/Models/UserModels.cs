
namespace TaxiManagment.Domia.Models
{
    class UserModels
    {
        public int Id { get; set; }
        public decimal Document { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime ModifyDate { get; set; }
        public string UserCreate { get; set; }
        public bool Delete { get; set; }
        public bool UpDated { get; set; }
        public DateTime UpdaeData { get; set; } = DateTime.Now;
        public int TaxiId {  get; set; }



    }
    }
