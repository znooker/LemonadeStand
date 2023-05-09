// See https://aka.ms/new-console-template for more information

using _1.Domain.Fruits;
using _1.Domain.Recipes;

Apple apple = new Apple();

Melon melon = new Melon();
Orange orange = new Orange();

Fruit appleOrange = new Apple();

List<IFruit> fruits = new List<IFruit> ();

fruits.Add (apple);

fruits.Add (melon);

fruits.Add (orange);

foreach (var f in fruits)
{
    Console.WriteLine(f.GetType().Name);
}

Console.WriteLine(  );
Console.WriteLine("JuiceMaker");
Recipe appleJuice = new Recipe("Apple Juice", apple, 2.5m, 25) ;

Console.WriteLine($"The beverage {appleJuice.Name} contains 100% {appleJuice.AllowedFruit.Name}s!");
