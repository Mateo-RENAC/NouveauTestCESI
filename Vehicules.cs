class Vehicule:IPilotage
{
    public string Name { get; private set; }

    public Vehicule()
    { }

    public Vehicule(String Name)
    {
        this.Name = Name;
    }

    public void Embarquer()
    {
        Console.WriteLine("Embarquement sur " + Name);
    }
}