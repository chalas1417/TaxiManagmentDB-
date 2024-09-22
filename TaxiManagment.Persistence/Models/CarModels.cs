namespace TaxiManagment.Persistence.Models
{
    public class CarModels
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public DateTime Year { get; set; } = DateTime.Now;
    }
}
