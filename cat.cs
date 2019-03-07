using System;

namespace Pets
{
    class Cat : Pet
    {
        public Cat(string petName, string ownerName, double petWeight) : base("Cat", petName, ownerName, petWeight)
        {
            name = petName;
            owner = ownerName;
            weight = petWeight;
        }

        public string meow(int count)
        {
            string talk = null;
            int i;
            for (i = 0; i < count; i++)
                talk += "meow...";
            return talk;
        }
    }
}