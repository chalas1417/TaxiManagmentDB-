using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaxiManagment.Domia.Base;

namespace TaxiManagment.Domia.Entities
{
    [Table("Trips", Schema ="dbo")]
    public sealed class Trip : AuditEntity<int>
    {
        [Key]
        [Column("TripId")]
        public override int Id { get; set; }
        public string From { get; set; }
        public string Until {  get; set; }
        public int Qualification {  get; set; }
    }
}
