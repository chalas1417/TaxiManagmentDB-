
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Drawing;

namespace TaxiManagment.Domia.Models
{
    public class VehicleModels
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public DateTime Year { get; set; }
        public string TypeVehcle {  get; set; }
        public string  Vehicle {  get; set; }
    }
}
