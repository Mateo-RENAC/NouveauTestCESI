using System.Linq;
using static Animal;
using static Dog;
class LINKTutorial
{
    public static void GestionChien()
    {
        Dog[] chennille = new Dog[]{new Dog("Snow"), new Dog("Spark"), new Dog("Princess"), new Dog("Issis"), new Dog("Ice")};

        var chenilleAdopter = from e in chennille where e.Name != "Snow" select e;
        
        foreach (Dog chienAdopter in chenilleAdopter)
        {
            Console.WriteLine(chienAdopter.Name);
        }
    }
}

