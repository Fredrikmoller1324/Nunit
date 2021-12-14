// See https://aka.ms/new-console-template for more information
using Builder;



//Burger burger = new Burger();
//
//burger.Cheese = true;
//burger.Pickles = true;

//Console.WriteLine(burger);

//burgerbuilder builder = new burgerbuilder();
//var burger = builder
//    .addnumberofpatties(-3)
//    .withcheese()
//    .build();

Burger burger = Burger
    .Builder
    .AddNumberOfPatties(1)
    .WithCheese()
    .Build();

Console.WriteLine(burger.ToString());
