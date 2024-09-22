using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaxiManagment.Domia.Base;

namespace TaxiManagment.Domia.Entities
{
    [Table("UserGroupDetails",Schema ="dbo")]
   public  class UserGroupDetail:AuditEntity<int>
    {
        [Key]
        [Column("UserGroupDetails")]
        public override int Id { get; set; }
    }
}
