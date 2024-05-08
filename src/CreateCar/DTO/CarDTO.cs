using CreateCar.Models;
using Microsoft.VisualBasic;

namespace CreateCar.DTO
{
    public class CarDTO
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

        public static bool IsValid(CarDTO carDTO)
        {
            return (!string.IsNullOrEmpty(carDTO.Brand)&& !string.IsNullOrEmpty(carDTO.Model) && carDTO.Year > 1900 && !string.IsNullOrEmpty(carDTO.Color));
        }
    }
}
