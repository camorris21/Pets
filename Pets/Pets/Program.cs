using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet newPet = new Pet("Dog", "Halo", "Chelsea", 7.2);
            Console.WriteLine("Name: " + newPet.name);
            Console.WriteLine("Weight: " + newPet.weight + " lbs");
            Console.WriteLine(newPet.getTag());

            Dog newDog = new Dog("Walt", "Logan", 32.5);
            Console.WriteLine("\nName: " + newDog.name);
            Console.WriteLine("Weight: " + newDog.weight + " lbs");
            Console.WriteLine(newDog.getTag());
            Console.WriteLine(newDog.bark(4));

            Cat newCat = new Cat("Steph", "Collin", 12.4);
            Console.WriteLine("\nName: " + newCat.name);
            Console.WriteLine("Weight: " + newCat.weight + " lbs");
            Console.WriteLine(newCat.getTag());
            Console.WriteLine(newCat.meow(2));

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}