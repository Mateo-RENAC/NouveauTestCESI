class Aigle : Bird, IFly
{
    public string? Name { get; set; }
    public int rarity { get; set; }

    public Aigle(string Name, int rarity = 1)
    {
        this.Name = Name;
        this.rarity = 3;
    }

    public void Voler()
    {
        Console.WriteLine("AMEERRRIICCAAA FUCK YEAH");
    }
}