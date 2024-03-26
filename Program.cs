using System.Reflection.Metadata;
using static Animal;


class Program
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Choose Animal : wolf or sheep");
        String user = Console.ReadLine();
        if (user.Equals("wolf")) 
        {
            Wolf choosing = new Wolf("wolf");
            Wolf.WhatAreYou();
            choosing.Sound();
            choosing.Moove();
            choosing.Sleep();
            Console.WriteLine("END_FUNCTION");
        }
        else if (user.Equals("sheep"))
        {
            Sheep choosing = new Sheep("sheep");
            Sheep.WhatAreYou();
            choosing.Sound();
            choosing.Moove();
            choosing.Sleep();
            Console.WriteLine("END_FUNCTION");
        }
        else
        {
            /* Animal animal = new Animal();*/
            Console.WriteLine("No_sound");
            animal.Moove();
            animal.Sleep();
            Console.WriteLine("END_FUNCTION");
        }
    }

}
