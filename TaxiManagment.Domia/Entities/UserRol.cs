using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaxiManagment.Domia.Base;

namespace TaxiManagment.Domia.Entities
{
    [Table("UserRols",Schema ="dbo")]
    public class UserRol : AuditEntity<int>
    {
        [Key]
        [Column("UserRols")]
        public override int Id {  get; set; }
        public int UserId {  get; set; }
    }
}
