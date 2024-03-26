using static Animal;


class Griffin : Animal
{

    public Griffin()
    {
    }

    public Griffin(String Name)
    {
        this.Name = Name;
    }

    public override void WhatAreYou()
    {
        Console.WriteLine("I'm Peter Griffin ehehehehehehehheheheheheheheheheh!");
    }

}

class Dragon : Animal
{
    public Dragon()
    {
    }

    public Dragon(String Name)
    {
        this.Name = Name;
    }

    public String DragonBreath()
    {
        return "Dragon use Flame";
    }

    public override void WhatAreYou()
    {
        Console.WriteLine("I'm a FUCKIN DRAGON " + DragonBreath() );
    }

}