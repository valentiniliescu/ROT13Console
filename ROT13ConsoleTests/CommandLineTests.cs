using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ROT13Console;

namespace ROT13ConsoleTests
{
    [TestClass]
    public class CommandLineTests
    {
        [TestMethod]
        [TestCategory("Integration")]
        public void ProvidesFirstCommandLineArgument()
        {
            //In .NET, you cannot modify command line arguments for the current process
            var cli = CommandLine.Create();
            var arg = cli.Arg;
            arg.Should().NotBeNull();
        }

        [TestMethod]
        public void ArgIsNullable()
        {
            var cli = CommandLine.CreateNull("my_arg");

            cli.Arg.Should().Be("my_arg");
        }
    }
}