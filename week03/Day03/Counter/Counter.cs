using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    public class Counter
    {
        public int Number { get; set; } = 0;

        public Counter()
        {
            this.Number = default;
        }
        public Counter(int number)
        {
            this.Number = number;
        }
        public void Add()
        {
            Number++;
        }
        public string Get()
        {
            return Convert.ToString(Number);
        }
        public void Reset()
        {
            this.Number = default;
        }
    }
}
