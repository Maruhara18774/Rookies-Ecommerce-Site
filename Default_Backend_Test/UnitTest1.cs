using System;
using Xunit;

namespace Default_Backend_Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestHello()
        {
            Assert.Equal("Hello A", SayHello("A"));
        }
        public string SayHello(string name)
        {
            return "Hello " + name;
        }

    }
}
