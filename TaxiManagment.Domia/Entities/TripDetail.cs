
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TaxiManagment.Domia.Base;

namespace TaxiManagment.Domia.Entities
{
    [Table("TripDetails",Schema ="dbo")]
    public class TripDetail: AuditEntity<int>
    {
        [Key]
        [Column("TripDetails")]
        public override int Id {  get; set; }   
        public DateTime Date { get; set; }
        public decimal Latitude {  get; set; }
        public decimal Legth { get; set; } = 0;


    }
}
