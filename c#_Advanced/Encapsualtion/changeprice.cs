using System;

public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

public class Stock
{
    public event PriceChangedHandler PriceChanged;

    private decimal _price;
    public decimal Price
    {
        get => _price;
        set
        {
            if (_price != value)
            {
                var oldPrice = _price;
                _price = value;
                if (PriceChanged != null)
{
    PriceChanged(oldPrice, value);
}
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var stock = new Stock();
        stock.PriceChanged += (oldPrice, newPrice) =>
        {
            Console.WriteLine($"Price updated: ${oldPrice} → ${newPrice}");
        };

        stock.Price = 2m;
    }
}