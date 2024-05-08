﻿namespace CreateCar.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public required string Brand { get; set; }
        public required string Model { get; set; }
        public required int Year { get; set; }
        public required string Color { get; set; }
        public required decimal Price { get; set; }


    }
}
