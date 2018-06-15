using System;
using System.IO;
using System.Text;
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
        [TestCategory("Integration")]
        public void WritesToConsole()
        {
            var consoleOutTemp = Console.Out;

            try
            {
                using (var memoryStream = new MemoryStream())
                using (var tw = new StreamWriter(memoryStream))
                {
                    Console.SetOut(tw);
                    var cli = CommandLine.Create();

                    cli.Output("test");

                    tw.Flush();

                    var outputValue = Encoding.Default.GetString(memoryStream.ToArray());
                    outputValue.Should().Be("test" + Environment.NewLine);
                }
            }
            finally
            {
                Console.SetOut(consoleOutTemp);
            }
        }

        [TestMethod]
        public void ArgIsNullable()
        {
            var cli = CommandLine.CreateNull("my_arg");

            cli.Arg.Should().Be("my_arg");
        }

        [TestMethod]
        public void ConsoleIsNullable()
        {
            var consoleOutTemp = Console.Out;

            try
            {
                using (var memoryStream = new MemoryStream())
                using (var tw = new StreamWriter(memoryStream))
                {
                    Console.SetOut(tw);
                    var cli = CommandLine.CreateNull("my_cli_arg");

                    cli.Output("test");

                    tw.Flush();

                    memoryStream.Position.Should().Be(0);
                }
            }
            finally
            {
                Console.SetOut(consoleOutTemp);
            }
        }

        [TestMethod]
        public void ProvidesLastLineWrittenToConsole()
        {
            var consoleOutTemp = Console.Out;
            Console.SetOut(TextWriter.Null);

            try
            {
                var cli = CommandLine.Create();
                cli.Output("test");
                cli.LastMessage.Should().Be("test");
            }
            finally
            {
                Console.SetOut(consoleOutTemp);
            }
        }
    }
}