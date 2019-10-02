using System;

namespace Comparable
{
    public class Domino : IComparable
    {
        private readonly int[] values;

        public Domino(int valueA, int valueB)
        {
            this.values = new int[] { valueA, valueB };
        }

        public int CompareTo(object obj)
        {
            var domino = obj as Domino;


            if (obj == null || values[0] > domino.values[0])
            {
                return 10;
            }
            else if (values[0] == domino.values[0])
            {
                return 0;
            }
            else
            {
                return -10;
            }
        }
        public int[] GetValues()
        {
            return values;
        }
    }
}