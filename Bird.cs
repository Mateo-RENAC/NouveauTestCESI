class Bird
{
    public string? Name;
    public int rarity { get; set; }
    public virtual void Voler() {
        Console.WriteLine("I belive I can flyyyyyyyy....");
        }
}