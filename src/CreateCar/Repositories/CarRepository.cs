using CreateCar.Entities;
using CreateCar.Models;
using CreateCar.Repositories.Interfaces;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace CreateCar.Repositories
{
    public class CarRepository (DbCarContext context) : ICarRepository
    {
        private readonly DbCarContext _context = context;
        public List<Entities.Car> GetAll()
        {
            return [.. _context.Cars
                .Select(car => new Entities.Car
                {
                    Id = car.Id,
                    Brand = car.Brand,
                    Model = car.Model,
                    Year  = car.Year,
                    Color = car.Color,
                    Price = car.Price

                })];
        }
        public Entities.Car? GetCarById(int id)
        {
            var car = _context.Cars
                .Where(car => car.Id == id)
                .Select(car => new Entities.Car
                {
                    Id = car.Id,
                    Brand = car.Brand,
                    Model = car.Model,
                    Year = car.Year,
                    Color = car.Color,
                    Price = car.Price
                }).FirstOrDefault();
            return car;
        }
        public string AddCar(DTO.CarDTO carDTO)
        {
            try
            {
                _context.Cars.Add(new Models.Car
                {
                    Brand = carDTO.Brand,
                    Model = carDTO.Model,
                    Year = carDTO.Year,
                    Color = carDTO.Color,
                    Price = carDTO.Price
                });
                _context.SaveChanges();
                return "Car has been added!";
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }

        }
        public string UpdateCar(int id, DTO.CarDTO carDTO)
        {
            try
            {
                var carToUpdate = _context.Cars.Find(id);
                if (carToUpdate == null)
                {
                    throw new InvalidOperationException("Car not found");
                }
                carToUpdate.Brand = carDTO.Brand;
                carToUpdate.Model = carDTO.Model;
                carToUpdate.Year = carDTO.Year;
                carToUpdate.Color = carDTO.Color;
                carToUpdate.Price = carDTO.Price;


                _context.SaveChanges();
                return "Car updated";
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public string DeleteCar(int id)
        {
            try
            {
                var carToDelete = _context.Cars.Find(id) ?? throw new InvalidOperationException("Car not found");
                _context.Cars.Remove(carToDelete!);
                _context.SaveChanges();

                return "Car deleted";
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }    
    }
}
