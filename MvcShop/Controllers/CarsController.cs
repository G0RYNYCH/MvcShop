namespace MvcShop.Controllers;

public class CarsController
{
    private readonly ICars cars;
    private readonly ICarsCategory carsCategory;

    public CarsController(ICars cars, ICarsCategory carsCategory)
    {
        this.cars = cars;
        this.carsCategory = carsCategory;
    }
}
