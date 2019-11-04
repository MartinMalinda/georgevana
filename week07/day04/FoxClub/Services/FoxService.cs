using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Service
{
    public class FoxService
    {
        public List<Fox> foxes;
        public List<string> foodTypes;
        public List<string> drinkTypes;
        public List<string> tricks;

        public FoxService()
        {
            foxes = new List<Fox>();
            foodTypes = new List<string>() { "pizza", "lasagne", "burgers", "salad", "burrito", "kebab", "chinese" };
            drinkTypes = new List<string>() { "fanta", "cola", "water", "lemonade", "tea", "coffee" };
            tricks = new List<string>() { "programming", "gaming", "kungfu", "pilot helicopter", "cooking" };
        }
        public Fox FindFoxByName(string name)
        {
            return foxes.Find(f => f.Name == name);
        }
    }
}
