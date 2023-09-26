class Wine : Drink
{
    public string Region { get; set; }
    public int Year { get; set; }

    public Wine(string name, string color, double temp, bool isCarb, int calories, string region, int year)
    : base(name, color, temp, isCarb, calories)
    {
        Region = region;
        Year = year;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Wine Region: {Region}");
        Console.WriteLine($"Wine Year: {Year}");
    }
}