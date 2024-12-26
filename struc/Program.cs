public struct Product
{
    public string Name;
    public int Kol;
    public double Price;
    public string Manufacturer;
    public DateTime ReleaseDate;

    public Product(string name, int kol, double price, string manufacturer, DateTime releaseDate)
    {
        Name = name;
        Kol = kol;
        Price = price;
        Manufacturer = manufacturer;
        ReleaseDate = releaseDate;
    }
}
class Program
{
    static void Main()
    {
        Product[] products = new Product[]
        {
            new Product("Телевизор", 10, 10000, "sumsung", new DateTime(2024, 10, 10)),
            new Product("Ноутбук", 2, 2000, "lenovo", new DateTime(2022, 3, 15)),
            new Product("Холодильник", 5, 50750, "German", new DateTime(2020, 8, 30))
        };

       
       
        double averagePrice = products.Average(p => p.Price);
        Console.WriteLine($"Средняя стоимость товаров: {averagePrice:F2} рублей");

        
        var minPriceProduct = products.OrderBy(p => p.Price).First();
        Console.WriteLine($"Товар с минимальной стоимостью: {minPriceProduct.Name}, Цена: {minPriceProduct.Price}");
    }
}