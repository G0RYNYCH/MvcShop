namespace MvcShop.Data.Mocks;
public class MockCars : ICars
{
    private readonly ICarsCategory category = new MockCategories();

    public IEnumerable<Car> GetCars
    {      

        get
        {
            return new List<Car>
            {
                new Car { Name = "Tesla", ShortDescription ="", LongDescription ="", Img ="", Price = 4500, IsFavorite = true, Available = true, Category = category.AllCategories.First() }
            };
        }
    }

    public IEnumerable<Car> GetFavoriteCars { get; set; }

    public Car GetCarById(int carId)
    {
        throw new NotImplementedException();
    }
}
