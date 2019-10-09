using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
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

        public Animal()
        {
            this.Hunger = 50;
            this.Thirst = 50;
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
