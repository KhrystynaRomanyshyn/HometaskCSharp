using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGroup
{
    public class Animal
    {
        public string Description()
        {
            return $"This is {GetType().Name}";
        }

        private int GetCount(Type type, Animal[] animals, bool isGetAnimalCount)
        {
            int counter = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                if (isGetAnimalCount)
                {
                    if (animals[i].GetType() == type)
                    {
                        counter++;
                    }
                }
                else
                {
                    if (animals[i].GetType().BaseType == type)
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }

        public int GetAnimalCount(Type type, Animal[] animals)   // Gets animals count using type of animal (Wolf, Fox etc)
        {
            return GetCount(type, animals, true);
        }

        public int GetAnimalsCountByClass(Type type, Animal[] animals)         // Gets animals count by class (Predators, Herbivores)
        {
            return GetCount(type, animals, false);
        }
    }
}
