namespace ROT13Console
{
    public class CommandLine
    {
        private readonly ICommandLineArgs _commandLineArgs;
        private readonly IConsole _console;

        public CommandLine(ICommandLineArgs commandLineArgs, IConsole console)
        {
            _commandLineArgs = commandLineArgs;
            _console = console;
        }

        public string Arg => _commandLineArgs.Arg;
        public string LastMessage { get; private set; }

        public static CommandLine Create()
        {
            return new CommandLine(new CommandLineArgs(), new ConsoleWrapper());
        }

        public static CommandLine CreateNull(string arg)
        {
            return new CommandLine(new NullCommandLineArgs(arg), new NullConsole());
        }

        public void Output(string message)
        {
            _console.WriteLine(message);
            LastMessage = message;
        }
    }
}