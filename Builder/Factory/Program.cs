// See https://aka.ms/new-console-template for more information

using Factory.Burgers;

BurgerFactory factory = new BurgerFactory();

Burger burger = factory.CreateBurger("doubleburger");

Console.WriteLine(burger);
