﻿using System.Reflection.Metadata;
using static Animal;
using static Griffin;
using static Dragon;
using static LINKTutorial;


class Program
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Tapez 1 : Gestion Chien\nTapez 2 : Drôle d'animeaux");
        string user = Console.ReadLine();

        if (user.Equals("1"))
        {
            GestionChien();
        }

        else if (user.Equals("2")) {
            Console.WriteLine("Choose Animal : Wolf, Sheep, Griffin, Dragon");

            if (user.Equals("Wolf"))
            {
                Wolf choosing = new Wolf("Wolf");
                choosing.WhatAreYou();
                choosing.Sound();
                choosing.Moove();
                choosing.Sleep();
                Console.WriteLine("END_FUNCTION");
            }
            else if (user.Equals("Sheep"))
            {
                Sheep choosing = new Sheep("Sheep");
                choosing.WhatAreYou();
                choosing.Sound();
                choosing.Moove();
                choosing.Sleep();
                Console.WriteLine("END_FUNCTION");
            }
            else if (user.Equals("Griffin"))
            {
                Griffin choosing = new Griffin("Griffin");
                choosing.WhatAreYou();
                choosing.Moove();
                choosing.Sleep();
                Console.WriteLine("END_FUNCTION");
            }
            else if (user.Equals("Dragon"))
            {
                Dragon choosing = new Dragon("Dragon");
                choosing.WhatAreYou();
                choosing.Moove();
                choosing.Embarquer();
                choosing.Sleep();
                Console.WriteLine("END_FUNCTION");
            }
            else
            {
                /* Animal animal = new Animal();
                Console.WriteLine("No_sound");
                animal.Moove();
                animal.Sleep();
                Console.WriteLine("END_FUNCTION");*/
                Console.WriteLine("NoneAnimalDoNotExist");
            }
        }
        else { Console.WriteLine("COMMANDE NON RECONNUE"); }
    }

}
