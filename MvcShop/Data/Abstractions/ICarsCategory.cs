namespace MvcShop.Data.Abstractions;

public interface ICarsCategory
{
    //QSTN: is it ok to use getter with func
    IEnumerable<Category> AllCategories { get; }
}
