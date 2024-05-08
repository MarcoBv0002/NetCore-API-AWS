using System.Drawing.Drawing2D;

namespace CreateCar.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Brand { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Year { get; set; } 
        public string Color { get; set; } = null!;
        public decimal Price { get; set; }



    }
}
