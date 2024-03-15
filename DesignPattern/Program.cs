// See https://aka.ms/new-console-template for more information
using DesignPattern.Creational;

Console.WriteLine("Hello, World!");

Singleton singleton1 = Singleton.GetInstance();
singleton1.DisplayMessage();

Singleton singleton2 = Singleton.GetInstance();
singleton2.DisplayMessage();

Console.WriteLine($"Are these instances same? {singleton1 == singleton2}");
