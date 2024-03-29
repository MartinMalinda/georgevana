﻿using System;
using System.Collections.Generic;

namespace Comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Domino> dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));

            dominoes.Sort();

            foreach (var item in dominoes)
            {
                int[] valuesToPrint = new int[2];
                valuesToPrint = item.GetValues();

                Console.Write($"[{valuesToPrint[0]},{valuesToPrint[1]}], ");
            }
        }
    }
}
