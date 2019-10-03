using System;
using Xunit;
using Sum;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private Suma sum;

        public UnitTest1()
        {
            sum = new Suma();
        }

        [Fact]
        public void Test1()
        {
            List<int> list = new List<int> { 1, 2, 3, 4 };
            Assert.Equal(10, sum.SumIntegers(list));
        }
        [Fact]
        public void Test2()
        {
            List<int> list = new List<int> { 1 };
            Assert.Equal(1, sum.SumIntegers(list));
        }
        [Fact]
        public void Test3()
        {
            List<int> list = new List<int>();
            Assert.Equal(0, sum.SumIntegers(list));
        }
        [Fact]
        public void Test4()
        {
            List<int> list = null;
            Assert.Equal(0, sum.SumIntegers(list));
        }
    }
}
