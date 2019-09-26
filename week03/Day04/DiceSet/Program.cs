using System;
using System.Collections.Generic;

namespace DiceSet
{
    class Program
    {
        public static void Main(string[] argv)
        {
            // You have a `DiceSet` class which has a list for 6 dice
            // You can roll all of them with roll()
            // Check the current rolled numbers with getCurrent()
            // You can reroll with reroll()
            // Your task is to roll the dice until all of the dice are 6

            DiceSet diceSet = new DiceSet();

            for (int i = 0; i < 6; i++)
            {
                while (diceSet.GetCurrent(i) != 6)
                {
                    diceSet.Reroll(i);
                }
            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Dice{i + 1}: {diceSet.GetCurrent(i)}");
            }
        }
    }
}