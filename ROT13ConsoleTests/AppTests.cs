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
            var cli = CommandLine.CreateNull("my_cli_arg");
            var app = new App(cli);
            var expected = app.Run();
            expected.Should().Be("zl_pyv_net");
        }
    }
}