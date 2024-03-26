using System.Security.Cryptography.X509Certificates;

abstract class Animal
{
    public string? Name;

    public void Moove()
    {
        if (Exist(Name))
        {
            Console.WriteLine(Name + " I'm mooving !");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("NoneExistAnimal is mooving");
            Console.ReadLine();
        }
    }

    public void Sleep()
    {
        if (Exist(Name))
        {
            Console.WriteLine(Name + " Zzz...");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("NoneExistAnimal is sleeping\n");
            Console.ReadLine();
        }
    }

    public virtual void WhatAreYou()
    {
        Console.WriteLine("I'm NoneExist Animal!");
    }

    public static bool Exist(String Name)
    {
        if (Name == null)
        {
            return false;
        }
        else { return true; }
    }

    public Animal(String Name)
    {
        this.Name = Name;
    }

    public Animal()
    {
        this.Name = null;
    }

}

class Wolf : Animal
{
    public String Sound()
    {
        Console.WriteLine("Aooouh!\n");
        return "Aooouh!\n";

    }

    public override void WhatAreYou()
    {
        Console.WriteLine("I'm a Wolf !");
    }

    public Wolf(String Name)
    {
        this.Name = Name;
    }

}

class Sheep : Animal
{
    public String Sound()
    {
        Console.WriteLine("Beeeh\n");
        return "Beeeh\n";
    }

    public Sheep(String Name)
    {
        this.Name = Name;
    }

    public override void WhatAreYou()
    {
        Console.WriteLine("I'm a Sheep !");
    }

}