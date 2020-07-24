using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet myFirstPet = new Dog("Molly", 18, 2, 5, "female", "chihuahua", "Ann Smith");
            myFirstPet.ShowInfo();
            Console.WriteLine("\n");
            myFirstPet.DoActivity();
            myFirstPet.MakeSound();
            Console.WriteLine("-------------------");

            Pet someDog = new Dog("Archie", 58, 32, 6, "male", "golden retriever", "Ann Smith");
            Decorator goodBoy = new PlayFetchDecorator();
            goodBoy.Decorate(someDog);
            goodBoy.ShowInfo();
            Console.WriteLine("\n");
            goodBoy.DoActivity();
            goodBoy.MakeSound();
            Console.WriteLine("-------------------");

            Pet newPet = new Dog("Ollie", 52, 17, 5, "male", "border collie", "Noah Johnson");
            Decorator playfullDog = new PlayFetchDecorator();
            playfullDog.Decorate(newPet);
            Decorator workingDog = new HerdDecorator();
            workingDog.Decorate(playfullDog);
            Decorator vaccinatedDog = new VaccinateDecorator();
            vaccinatedDog.Decorate(workingDog);
            vaccinatedDog.ShowInfo();
            Console.WriteLine("\n");
            vaccinatedDog.DoActivity();
            vaccinatedDog.MakeSound();
            Console.WriteLine("-------------------");

            Console.ReadKey();
        }
    }

}
