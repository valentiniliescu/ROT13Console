using System;
using System.Linq;

namespace ROT13Console
{
    public class CommandLine
    {
        public string Arg => Environment.GetCommandLineArgs().Skip(1).FirstOrDefault();

        public static CommandLine Create()
        {
            return new CommandLine();
        }
    }
}