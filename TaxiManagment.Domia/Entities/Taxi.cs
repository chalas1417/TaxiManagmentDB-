using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaxiManagment.Domia.Base;

namespace TaxiManagment.Domia.Entities
{
    [Table("Taxis", Schema ="dbo")]
    public class Taxi : AuditEntity<int>
    {
        [Key]
        [Column("Taxis")]
        public override int Id { get; set; }
        public DateTime StarDate {  get; set; }
        public DateTime StarEnd {  get; set; }
        public string Until {  get; set; }
        public decimal Qualification {  get; set; }

    }
}
