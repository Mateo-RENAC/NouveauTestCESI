using System.Linq;
using static Animal;
using static Dog;
class LINKTutorial
{
    public static void GestionChien()
    {

        Console.WriteLine("Taper 1 : Enlever 1 chien ?\nTaper 2 : Afficher Chien + rareté dans l'ordre décroissant\n");
        string user = Console.ReadLine();

        Dog[] chennille = new Dog[] { new Dog("Snow"), new Dog("Spark"), new Dog("Princess"), new Dog("Issis"), new Dog("Ice") }
        if (user.Equals("1")) { 

            var chenilleAdopter = from e in chennille where e.Name != "Snow" select e;

            foreach (Dog chienAdopter in chenilleAdopter)
            {
                Console.WriteLine(chienAdopter.Name);
            }
        }
        else if (user.Equals("2"))
        {

        }
        else
        {
            Console.WriteLine("1 ou 2");
        }
    }
}

