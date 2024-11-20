
List<Product> products = new List<Product>()
{
    new Product()
    { 
        Name = "Football", 
        Price = 15, 
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010
    },
    new Product() 
    { 
        Name = "Hockey Stick", 
        Price = 12, 
        Sold = false,
        StockDate = new DateTime(2024, 9, 17),
        ManufactureYear = 2018
    },
    new Product()
    {
        Name = "Frisbee",
        Price = 10,
        Sold = false
        StockDate = new DateTime(2024, 9, 17),
        ManufactureYear = 2023
    },
    new Product()
    {
        Name = "Soda-Drink Hat",
        Price = 25,
        Sold = false,
        StockDate = new DateTime(2019, 11, 27),
        ManufactureYear = 2009
    },
    new Product()
    {
        Name = "Sofa",
        Price = 900,
        Sold = false,
        StockDate = new DateTime(2024, 3, 20),
        ManufactureYear = 2024
    },
    new Product()
    {
        Name = "Black Hole Pro HD",
        Price = 200,
        Sold = false,
        StockDate = new DateTime(2024, 9, 17),
        ManufactureYear = 2021
    },
    new Product()
    {
        Name = "43 Chicken Nuggets",
        Price = 15,
        Sold = true,
        StockDate = new DateTime(2024, 11, 16),
        ManufactureYear = 2024
    }
};

string greeting = @"Welcome to Thrown for a Loop
Your one-stop shop for used sporting equipment";

Console.WriteLine(greeting);
Console.WriteLine("Products:");
for (int i=0; i < products.Count; i++)
{
    Console.WriteLine($"{i+1}. {products[i].Name}");
}
Console.WriteLine("Please enter a product number: ");

int response = int.Parse(Console.ReadLine().Trim());

while (response > products.Count || response < 1)
{
    Console.WriteLine($"Choose a number between 1 and {products.Count}!");
    response = int.Parse(Console.ReadLine().Trim());
}
Product chosenProduct = products[response - 1];
Console.WriteLine($"You chose: {chosenProduct.Name}, which costs {chosenProduct.Price} dollars and is {(chosenProduct.Sold ? "" : "not ")}sold.");


