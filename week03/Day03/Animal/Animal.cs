using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Animal
    {
        public int Hunger { get; set; }
        public int Thirst { get; set; }


        public Animal(int hunger, int thirst)
        {
            this.Hunger = hunger;
            this.Thirst = thirst;
        }

        public void Eat()
        {
            Hunger--;
        }
        public void Drink()
        {
            Thirst--;
        }
        public void Play()
        {
            Hunger++;
            Thirst++;
        }
    }
}
