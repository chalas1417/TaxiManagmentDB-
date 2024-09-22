using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaxiManagment.Domia.Base;

namespace TaxiManagment.Domia.Entities
{
    [Table("Vehicles", Schema ="dbo")]
    public class Vehicle : AuditEntity<int>
    {
        [Key]
        [Column("Vehicles")]
        public override int Id { get; set; }
        public string TypeVeichle {  get; set; }
        public string VeicleModel {  get; set; }
        public DateTime Year { get; set; }
    }
}
