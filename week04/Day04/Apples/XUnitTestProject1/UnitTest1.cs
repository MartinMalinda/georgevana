using System;
using Xunit;
using Apples_exercise;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private Apple apples;

        public UnitTest1()
        {
            apples = new Apple();
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal("apple", apples.GetApple());
        }
    }
}
