using CreateCar.DTO;
using CreateCar.Entities;
using CreateCar.Repositories.Interfaces;

namespace CreateCar.Services
{
    public class CarService (ICarRepository carRepository)
    {
        private readonly ICarRepository _carRepository = carRepository;

        public List<Car> GetAll()
        {
            return _carRepository.GetAll();
        }
        public Car GetCarById(int id)
        {
            return _carRepository.GetCarById(id);
        }
        public string AddCar(CarDTO carDTO)
        {
            return _carRepository.AddCar(carDTO);
        }
        public string UpdateCar(int id, CarDTO carDTO)
        {
            return _carRepository.UpdateCar(id, carDTO);
        }
        public string DeleteCar(int id)
        {
            return _carRepository.DeleteCar(id);
        }
    }
}
