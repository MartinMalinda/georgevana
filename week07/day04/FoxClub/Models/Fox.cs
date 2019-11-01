using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public List<string> tricks;
        public string food;
        public string drink;

        public Fox(string name)
        {
            Name = name;
            this.tricks = new List<string>();
            this.food = "";
            this.drink = "";
        }

        public Fox()
        {

        }
    }
}
