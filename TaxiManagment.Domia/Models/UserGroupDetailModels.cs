namespace TaxiManagment.Domia.Models
{
    public class UserGroupDetailModels
    {
        public int Id { get; set; }
        public int UserGropuId {  get; set; }
        public DateTime ModifyDate { get; set; }
        public string UserCreate { get; set; }
        public bool Delete { get; set; }
        public bool UpDated { get; set; }
        public DateTime UpdaeData { get; set; } = DateTime.Now; 
   

    }
}
