namespace MvcShop.Data.Mocks;

public class MockCategories : ICarsCategory
{
    public IEnumerable<Category> AllCategories
    {
        get
        {
            return new List<Category>
            {
                new Category{ CategoryName = "Electric car", Description = "Modern vehicle" },
                new Category{ CategoryName = "ICE car", Description = "Cars with internal combustion engine" },
            };
        }
    }
}
