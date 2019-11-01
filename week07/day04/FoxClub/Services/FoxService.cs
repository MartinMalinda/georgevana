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

        public FoxService()
        {
            foxes = new List<Fox>();
        }
        public Fox FindFoxByName(string name)
        {
            return foxes.Find(f => f.Name == name);
        }
    }
}
