namespace MvcShop.Data.Models;

public class Car
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string ShortDescription { get; set; }

    public string LongDescription { get; set; }

    public string Img { get; set; }

    public decimal Price { get; set; }

    public bool IsFavorite { get; set; }

    public bool Available { get; set; }

    public int CategoryId { get; set; }

    public Category Category { get; set; }
}
