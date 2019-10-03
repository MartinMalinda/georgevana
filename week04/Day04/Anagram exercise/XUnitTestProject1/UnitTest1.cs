using System;
using Xunit;
using Anagram;

namespace AnagramTest
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            string string1 = "silent";
            string string2 = "listen";
            Assert.True(Program.IsAnagram(string1, string2));
        }
    }
}