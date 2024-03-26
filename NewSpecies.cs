using static Animal;
using static Vehicule;
using static IPilotage;


class Griffin : Animal
{

    public Griffin()
    {
    }

    public Griffin(string Name)
    {
        this.Name = Name;
    }

    public override void WhatAreYou()
    {
        Console.WriteLine("I'm Peter Griffin ehehehehehehehheheheheheheheheheh!");
    }

}

class Dragon : Animal, IPilotage
{
    public Dragon()
    {
    }

    public Dragon(string Name)
    {
        this.Name = Name;
    }

    public string DragonBreath()
    {
        return "Dragon use Flame";
    }

    public override void WhatAreYou()
    {
        Console.WriteLine("I'm a FUCKIN DRAGON " + DragonBreath() );
    }

    public void Embarquer()
    {
        Console.WriteLine("Embarquement sur " + Name);
    }

}