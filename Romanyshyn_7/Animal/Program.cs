using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Description();

            Animal predators = new Predators();
            predators.Description();

            Animal[] animals =
            {
                new Fox(),
                new Wolf(),
                new Fox(),
                new Rabbit()
            };

            int amount = GetAnimalCount(typeof(Fox), animals);
            int amount2 = GetAnimalsCountByClass(typeof(Predators), animals);
        }

        static int GetAnimalCount(Type type, Animal[] animals)   // Gets animals count using type of animal (Wolf, Fox etc)
        {
            int counter = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i].GetType() == type)
                {
                    counter++;
                }
            }

            return counter;
        }

        static int GetAnimalsCountByClass(Type type, Animal[] animals)         // Gets animals count by class (Predators, Herbivores)
        {
            int counter = 0;
            for(int i = 0; i < animals.Length; i++)
            {
               
                if (animals[i].GetType().BaseType == type)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
