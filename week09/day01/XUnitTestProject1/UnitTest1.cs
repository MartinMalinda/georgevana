using System;
using Xunit;
using DOJOGetIndex;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        List<int> ints = new List<int>(){ 1, 2, 3, 4, 5, 6};

        int index = 2;
        [Fact]
        public void Test1()
        {
            Assert.Equal(-1, Program.GetIndex(ints, index));
        }
    }
}
