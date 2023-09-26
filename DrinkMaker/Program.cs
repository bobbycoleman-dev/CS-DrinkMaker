// Create two Soda's
Soda DietCoke = new("Diet Coke", "Dark Brown", 36.00, 400, true);
Soda MtDew = new("Mt Dew", "Green", 36.00, 350, false);

// Create two Coffee's
Coffee JustBlack = new("BRC JustBlack", "Black", 205.00, 90, "Medium", "Medium Coarse");
Coffee ColdBrew = new("Cold Brew", "Light Brown", 36.5, 120, "Light", "Fine");

// Create two Wine's
Wine Pull = new("Pull Cabernet", "Purple", 75.6, false, 60, "Pasa Robles, CA", 2018);
Wine Champagne = new("Dom Pérignon", "Light Oak", 38.00, true, 100, "Champagne, France", 1960);

List<Drink> AllBeverages = new()
{
    DietCoke,
    MtDew,
    JustBlack,
    ColdBrew,
    Pull,
    Champagne
};

foreach (Drink drink in AllBeverages)
{
    drink.ShowDrink();
    Console.WriteLine("\n");
}

// Coffee MyDrink = new Soda("Diet Coke", "Dark Brown", 36.00, 400, true);
// This is unable to work because Coffee and Soda are two different classes that have their own parameters and fields
// Because they are different, it is expecting that we wish to convert our Coffee instance into a Soda instance, which is not possible