namespace ROT13Console
{
    public class CommandLine
    {
        private readonly ICommandLineArgs _commandLineArgs;

        public CommandLine(ICommandLineArgs commandLineArgs)
        {
            _commandLineArgs = commandLineArgs;
        }

        public string Arg => _commandLineArgs.Arg;

        public static CommandLine Create()
        {
            return new CommandLine(new CommandLineArgs());
        }

        public static CommandLine CreateNull(string arg)
        {
            return new CommandLine(new NullCommandLineArgs(arg));
        }
    }
}