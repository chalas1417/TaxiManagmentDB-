namespace TaxiManagment.Persistence.Models
{
    public class TripDetailModels
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Latitude { get; set; }
        public decimal Legth { get; set; } = 0;

    }
}
