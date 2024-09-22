
namespace TaxiManagment.Domia.Base
{
    public abstract class AuditEntity<TType>:BaseEntity<TType>
    {
        
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public string UserCreate { get; set; }
        public string? UserUpdate { get; set; }
        public bool? Delete { get; set; } = false;
        public bool? Updated { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string UserMod {  get; set; }    







    }
}
