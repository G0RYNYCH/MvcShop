namespace MvcShop.Data.Abstractions;

public interface ICars
{
    IEnumerable<Car> GetCars { get; }
    IEnumerable<Car> GetFavoriteCars { get; }
    Car GetCarById(int carId);
}
