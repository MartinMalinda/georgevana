using System;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            // - You have the `Thing` class
            // - You have the `Fleet` class
            // - You have the `FleetOfThings` class with a `Main` method
            // - Download those, use those
            // - In the Main method create a fleet
            // - Achieve this output:s
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also

            Fleet fleet = new Fleet();

            Thing milk = new Thing("Get milk");
            Thing obstacles = new Thing("Remove the obstacles");
            Thing standUp = new Thing("Stand up");
            standUp.Complete();
            Thing eatLunch = new Thing("Eat lunch");
            eatLunch.Complete();

            fleet.Add(milk);
            fleet.Add(obstacles);
            fleet.Add(standUp);
            fleet.Add(eatLunch);


            fleet.PrintList();
        }
    }
}