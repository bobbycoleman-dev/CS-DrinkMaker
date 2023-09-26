class Coffee : Drink
{
    public string RoastLevel { get; set; }
    public string BeanGrind { get; set; }

    public Coffee(string name, string color, double temp, int calories, string roast, string bean)
    : base(name, color, temp, false, calories)
    {
        RoastLevel = roast;
        BeanGrind = bean;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Roast Level: {RoastLevel}");
        Console.WriteLine($"Bean Grind: {BeanGrind}");
    }
}