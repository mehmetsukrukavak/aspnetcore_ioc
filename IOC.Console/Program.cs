// See https://aka.ms/new-console-template for more information
using IOC.Console;

Console.WriteLine("Hello, World!");


BL bl = new BL();
bl.GetProducts().ForEach(x =>
{
    Console.WriteLine($"{x.Id} - {x.Name} - {x.Price} - {x.Stock}");
});

Console.ReadLine();

