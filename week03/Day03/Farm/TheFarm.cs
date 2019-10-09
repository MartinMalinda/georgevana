using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farm
{
    class TheFarm
    {
        public List<Animal> ListOfAnimals { get; set; }
        public int FreeSlots { get; set; }

        public TheFarm(int freeSlots)
        {
            this.FreeSlots = freeSlots;
        }
        public void Breed()
        {
            if (FreeSlots > 0)
            {
                Animal animal = new Animal();
                ListOfAnimals.Add(animal);
                FreeSlots--;
            }
            else
            {
                Console.WriteLine("No free slots");
            }
        }

        public void SlaughterOne()
        {
            int hunger = 50;
            int index = 0;

            for (int i = 0; i < ListOfAnimals.Count; i++)
            {
                if (ListOfAnimals[i].Hunger <= hunger)
                {
                    hunger = ListOfAnimals[i].Hunger;
                    index = i;
                }
            }
            ListOfAnimals.Remove(ListOfAnimals[index]);
        }

        public void SlaughterLinq()
        {
            var hungryAnimal = ListOfAnimals.OrderByDescending(a => a.Hunger).First();
            ListOfAnimals.Remove(hungryAnimal);
        }
    }
}
