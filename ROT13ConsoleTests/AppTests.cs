using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ROT13Console;

namespace ROT13ConsoleTests
{
    [TestClass]
    public class AppTests
    {
        [TestMethod]
        public void EncodesHello()
        {
            var app = new App();
            var expected = app.Run();
            expected.Should().Be("uryyb");
        }
    }
}