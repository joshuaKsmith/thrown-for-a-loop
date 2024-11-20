
List<Product> products = new List<Product>()
{
    new Product()
    { 
        Name = "Football", 
        Price = 15.00M, 
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010,
        Condition = 4.2
    },
    new Product() 
    { 
        Name = "Hockey Stick", 
        Price = 12.00M, 
        Sold = false,
        StockDate = new DateTime(2024, 9, 17),
        ManufactureYear = 2018,
        Condition = 4.9
    },
    new Product()
    {
        Name = "Frisbee",
        Price = 10.00M,
        Sold = false,
        StockDate = new DateTime(2024, 9, 17),
        ManufactureYear = 2023,
        Condition = 5.0
    },
    new Product()
    {
        Name = "Soda-Drink Hat",
        Price = 25.00M,
        Sold = false,
        StockDate = new DateTime(2019, 11, 27),
        ManufactureYear = 2009,
        Condition = 2.7
        },
    new Product()
    {
        Name = "Sofa",
        Price = 900.00M,
        Sold = false,
        StockDate = new DateTime(2024, 3, 20),
        ManufactureYear = 2016,
        Condition = 2.1
    },
    new Product()
    {
        Name = "Black Hole Pro HD",
        Price = 200.00M,
        Sold = false,
        StockDate = new DateTime(2024, 9, 17),
        ManufactureYear = 2021,
        Condition = 5.0
    },
    new Product()
    {
        Name = "43 Chicken Nuggets",
        Price = 15.00M,
        Sold = true,
        StockDate = new DateTime(2024, 11, 16),
        ManufactureYear = 2024,
        Condition = 1.6
    }
};

Console.WriteLine(
    @"Welcome to Thrown for a Loop
    Your one-stop shop for used sporting equipment"
);

// User Menu
string choice = null;
while (choice != "0")
{
    Console.WriteLine(
        @"Choose an option:
        0. Exit
        1. View Product Details"
    );
    choice = Console.ReadLine();
    if (choice == "0")
    {
        Console.WriteLine("Goodbye!");
    }
    else if (choice == "1")
    {
        ViewProductDetails();
    }
}

void ViewProductDetails()
{
    // Total Value
    decimal totalValue = 0.00M;
    foreach (Product product in products)
    {
        if (!product.Sold)
        {
            totalValue += product.Price;
        }
    }
    Console.WriteLine($"Total inventory value: {totalValue}");

    // Product List
    Console.WriteLine("Products:");
    for (int i=0; i < products.Count; i++)
    {
        Console.WriteLine($"{i+1}. {products[i].Name}");
    }

    // User Product Selection
    Product chosenProduct = null;
    while (chosenProduct == null)
    {
        Console.WriteLine($"Please enter a product number between 1 and {products.Count}: ");
        try
        {
            int response = int.Parse(Console.ReadLine().Trim());
            chosenProduct = products[response - 1];
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Invalid input!");
        }
    }

    // Timespan Calculation
    DateTime now = DateTime.Now;
    TimeSpan timeInStock = now - chosenProduct.StockDate;

    // Product Details
    Console.WriteLine(
        @$"You chose: 
        {chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
        It is {now.Year - chosenProduct.ManufactureYear} years old. 
        It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}
        It is rated {chosenProduct.Condition}/5.0 on our condition scale."
    );
}