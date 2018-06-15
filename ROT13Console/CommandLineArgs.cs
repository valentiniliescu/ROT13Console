using System;
using System.Linq;

namespace ROT13Console
{
    public class CommandLineArgs : ICommandLineArgs
    {
        public string Arg => Environment.GetCommandLineArgs().Skip(1).FirstOrDefault();
    }
}