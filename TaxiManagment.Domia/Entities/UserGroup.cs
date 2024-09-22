using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaxiManagment.Domia.Base;

namespace TaxiManagment.Domia.Entities
{
    [Table("UserGroups",Schema ="dbo")]
   public class UserGroup: AuditEntity<int>
    {
        [Key]
        [Column("UserGroups")]
        public override int Id { get; set; }
    }
}
