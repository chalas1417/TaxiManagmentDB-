
using TaxiManagment.Domia.Base;

namespace TaxiManagment.Domia.Entities
{
    public class Car : AuditEntity<int>
    {
        public override int Id { get; set; }
        public int TaxiId { get; set; }
        public string Color { get; set; }
        public DateTime Year { get; set; }
    }
}
