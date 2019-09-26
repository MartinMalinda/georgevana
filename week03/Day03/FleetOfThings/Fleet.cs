using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class Fleet
    {
        private List<Thing> things;

        public Fleet()
        {
            things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            things.Add(thing);
        }

        public void PrintList()
        {
            for (int i = 0; i < things.Count; i++)
            {
                Console.Write($"{i + 1}. [");
                if (things[i].IsCompleted() == true)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(" ");
                }
                Console.WriteLine("] " + things[i].GetName());
            }
        }
    }
}