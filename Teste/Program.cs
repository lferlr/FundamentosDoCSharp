using System;

namespace Teste
{
  class Program
  {
    static void Main(string[] args)
    {
      var mouse = new Product(1, "Mouse Gramer", 299.97, EProductType.Product);

      Console.WriteLine(mouse.Id);
      Console.WriteLine(mouse.Name);
      Console.WriteLine(mouse.Price);
      Console.WriteLine(mouse.Type);

      Console.WriteLine(mouse.PriceInDolar(4.50));
    }
  }

  struct Product
  {
    public Product(int id, string name, double price, EProductType type)
    {
      Id = id;
      Name = name;
      Price = price;
      Type = type;
    }

    public int Id;
    public string Name;
    public double Price;
    public EProductType Type;

    public double PriceInDolar(double dolar)
    {
      return Price * dolar;
    }
  }

  enum EProductType
  {
    Product = 1,
    Service
  }
}