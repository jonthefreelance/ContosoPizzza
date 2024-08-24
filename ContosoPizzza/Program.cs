using ContosoPizzza.Data;
using ContosoPizzza.Models;

using ContosoPizzaContext context = new ContosoPizzaContext();

//Product veggieSpecial = new Product()
//{
//    Name = "Veggie Special Pizza",
//    Price = 9.99M
//};

//context.Products.Add(veggieSpecial);

//Product deluxeMeat = new Product()
//{
//    Name = "Deluxe Meat Pizza",
//    Price = 12.99M
//};

//context.Add(deluxeMeat);
//context.SaveChanges();

var products =
    //context.Products
    //.Where(p => p.Price > 10.00M)
    //.OrderBy(p => p.Name);
    from product in context.Products
    where product.Price > 10.00M
    orderby product.Name
    select product;

foreach(Product p in products)
{
    Console.WriteLine($"Id:    {p.Id}");
    Console.WriteLine($"Name:  {p.Id}");
    Console.WriteLine($"Price: {p.Id}");
    Console.WriteLine(new string('-', 20));
}

