namespace MvcShop.Controllers;

public class CarsController: Controller
{
    private readonly ICars cars;
    private readonly ICarsCategory carsCategory;

    public CarsController(ICars cars, ICarsCategory carsCategory)
    {
        this.cars = cars;
        this.carsCategory = carsCategory;
    }

    public ViewResult ListOfCars()
    {
        var listOfCars = cars.GetCars;
        return View(listOfCars);
    }
}
