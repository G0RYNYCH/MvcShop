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
                new Car { 
                    Name = "Tesla model 3",
                    ShortDescription ="Fast and practical",
                    LongDescription ="Comfortable for city life",
                    Img ="https://tesla-cdn.thron.com/delivery/public/image/tesla/c82315a6-ac99-464a-a753-c26bc0fb647d/bvlatuR/std/1200x628/lhd-model-3-social",
                    Price = 30000,
                    IsFavorite = true,
                    Available = true,
                    Category = category.AllCategories.First()
                },
                new Car {
                    Name = "Ford Fiesta",
                    ShortDescription ="Quite and calm",
                    LongDescription ="Comfortable for city life",
                    Img ="https://www.cars2buy.co.uk/images/car/1200/99083.jpg",
                    Price = 15000,
                    IsFavorite = false,
                    Available = true,
                    Category = category.AllCategories.Last()
                },
                new Car {
                    Name = "BMW M3",
                    ShortDescription ="Daring and stylish",
                    LongDescription ="Comfortable for city life",
                    Img ="https://4kwallpapers.com/images/wallpapers/vorsteiner-bmw-m3-vrs-aero-program-2022-5k-8k-white-3440x1440-7356.jpg",
                    Price = 45000,
                    IsFavorite = true,
                    Available = true,
                    Category = category.AllCategories.Last()
                },
                new Car {
                    Name = "Mercedes E class",
                    ShortDescription ="Cosy and soft",
                    LongDescription ="Comfortable for city life",
                    Img ="https://stimg.cardekho.com/images/carexteriorimages/930x620/Mercedes-Benz/E-Class/8409/1615887045542/front-left-side-47.jpg",
                    Price = 40000,
                    IsFavorite = true,
                    Available = true,
                    Category = category.AllCategories.Last()
                },
                new Car {
                    Name = "Nisssan Leaf",
                    ShortDescription ="Silent and economical",
                    LongDescription ="Comfortable for city life",
                    Img ="https://ev-database.org/img/auto/Nissan_Leaf_2022/Nissan_Leaf_2022-01.jpg",
                    Price = 30000,
                    IsFavorite = false,
                    Available = true,
                    Category = category.AllCategories.First()
                },
            };
        }
    }

    public IEnumerable<Car> GetFavoriteCars { get; set; }

    public Car GetCarById(int carId)
    {
        throw new NotImplementedException();
    }
}
