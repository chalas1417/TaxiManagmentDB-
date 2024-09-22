using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaxiManagment.Domia.Base;

namespace TaxiManagment.Domia.Entities
{
    [Table("Rols", Schema ="dbo")]
    public sealed class Rol :AuditEntity<int>
    {
        [Key]
        [Column("Rols")]
        public override int Id { get; set; }

        public string Description {  get; set; }

        public int UserRolId {  get; set; } 
       

    }
}
