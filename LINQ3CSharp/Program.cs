using System;
using System.Collections.Generic;
using System.Linq;
var phones = new List<Phone>
        {
            new Phone { Name = "Galaxy S22", Manufacturer = "Samsung", Price = 799, ReleaseDate = new DateTime(2022, 2, 25) },
            new Phone { Name = "iPhone 13", Manufacturer = "Apple", Price = 999, ReleaseDate = new DateTime(2021, 9, 24) },
            new Phone { Name = "Pixel 7", Manufacturer = "Google", Price = 599, ReleaseDate = new DateTime(2022, 10, 13) },
            new Phone { Name = "Galaxy A52", Manufacturer = "Samsung", Price = 499, ReleaseDate = new DateTime(2021, 3, 17) },
            new Phone { Name = "iPhone SE", Manufacturer = "Apple", Price = 429, ReleaseDate = new DateTime(2022, 3, 18) },
        };


Console.WriteLine($"Total phones: {phones.Count()}");
Console.WriteLine($"Phones with price > 100: {phones.Count(p => p.Price > 100)}");
Console.WriteLine($"Phones with price between 400 and 700: {phones.Count(p => p.Price >= 400 && p.Price <= 700)}");
Console.WriteLine($"Phones by Samsung: {phones.Count(p => p.Manufacturer == "Samsung")}");

var minPricePhone = phones.OrderBy(p => p.Price).FirstOrDefault();
Console.WriteLine($"Phone with minimum price: {minPricePhone?.Name} - {minPricePhone?.Price:C}");

var maxPricePhone = phones.OrderByDescending(p => p.Price).FirstOrDefault();
Console.WriteLine($"Phone with maximum price: {maxPricePhone?.Name} - {maxPricePhone?.Price:C}");

var oldestPhone = phones.OrderBy(p => p.ReleaseDate).FirstOrDefault();
Console.WriteLine($"Oldest phone: {oldestPhone?.Name} released on {oldestPhone?.ReleaseDate.ToShortDateString()}");

var newestPhone = phones.OrderByDescending(p => p.ReleaseDate).FirstOrDefault();
Console.WriteLine($"Newest phone: {newestPhone?.Name} released on {newestPhone?.ReleaseDate.ToShortDateString()}");

Console.WriteLine($"Average phone price: {phones.Average(p => p.Price):C}");


Console.WriteLine("Top 5 most expensive phones:");
foreach (var phone in phones.OrderByDescending(p => p.Price).Take(5))
{
    Console.WriteLine($"{phone.Name} - {phone.Price:C}");
}

Console.WriteLine("Top 5 cheapest phones:");
foreach (var phone in phones.OrderBy(p => p.Price).Take(5))
{
    Console.WriteLine($"{phone.Name} - {phone.Price:C}");
}

Console.WriteLine("Top 3 oldest phones:");
foreach (var phone in phones.OrderBy(p => p.ReleaseDate).Take(3))
{
    Console.WriteLine($"{phone.Name} released on {phone.ReleaseDate.ToShortDateString()}");
}

Console.WriteLine("Top 3 newest phones:");
foreach (var phone in phones.OrderByDescending(p => p.ReleaseDate).Take(3))
{
    Console.WriteLine($"{phone.Name} released on {phone.ReleaseDate.ToShortDateString()}");
}


Console.WriteLine("Phone count by manufacturer:");
foreach (var group in phones.GroupBy(p => p.Manufacturer))
{
    Console.WriteLine($"{group.Key} - {group.Count()}");
}

Console.WriteLine("Phone count by model:");
foreach (var group in phones.GroupBy(p => p.Name))
{
    Console.WriteLine($"{group.Key} - {group.Count()}");
}

Console.WriteLine("Phone count by release year:");
foreach (var group in phones.GroupBy(p => p.ReleaseDate.Year))
{
    Console.WriteLine($"{group.Key} - {group.Count()}");
}
class Phone
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }
}


