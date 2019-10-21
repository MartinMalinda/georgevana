using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> listOfFoxes = new List<Fox>();

            Fox james = new Fox("james", "usoun", "green");
            Fox kames = new Fox("kames", "pallida", "blue");
            Fox lames = new Fox("lames", "pallida", "green");
            Fox hames = new Fox("hames", "pallida", "grey");
            Fox games = new Fox("games", "rukoun", "yellow");

            listOfFoxes.Add(james);
            listOfFoxes.Add(kames);
            listOfFoxes.Add(lames);
            listOfFoxes.Add(hames);
            listOfFoxes.Add(games);

            var greenFoxes = listOfFoxes.Where(l => l.Color == "green").Select(l => l);
            var greenPallidaFoxes = listOfFoxes.Where(l => l.Color == "green" && l.Type.Equals("pallida")).Select(l => l);
        }
    }
}
