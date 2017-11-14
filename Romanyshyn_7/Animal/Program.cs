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
        }
    }
}
