
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaxiManagment.Domia.Base;

namespace TaxiManagment.Domia.Entities
{  
    [Table("UserGroupRequests", Schema ="dbo")]
    public class UserGroupRequest : AuditEntity<int>
    {
        [Key]
        [Column("UserGroupRequests")]
        public override int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour {  get; set; }
    }
}
