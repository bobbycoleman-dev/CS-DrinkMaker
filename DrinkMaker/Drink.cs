class Drink
{
    public string Name { get; set; }
    public string Color { get; set; }
    public double Temperature { get; set; }
    public bool IsCarbonated { get; set; }
    public int Calories { get; set; }

    public Drink(string name, string color, double temp, bool isCarb, int calories)
    {
        Name = name;
        Color = color;
        Temperature = temp;
        IsCarbonated = isCarb;
        Calories = calories;
    }

    public virtual void ShowDrink()
    {
        Console.WriteLine($"Drink Name: {Name}");
        Console.WriteLine($"Drink Color: {Color}");
        Console.WriteLine($"Drink Temp: {Temperature}");
        Console.WriteLine($"Is Carbonated: {IsCarbonated}");
        Console.WriteLine($"Calories: {Calories}");
    }
}