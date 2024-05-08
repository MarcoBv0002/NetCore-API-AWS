using CreateCar.Entities;

namespace CreateCar.Repositories.Interfaces
{
    public interface ICarRepository
    {
        List<Car> GetAll();
        Car GetCarById(int id);
        string AddCar(DTO.CarDTO carDTO);
        string UpdateCar(int id, DTO.CarDTO carDTO);
        string DeleteCar(int id);
    }
}
