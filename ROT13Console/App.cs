namespace ROT13Console
{
    public class App
    {
        private readonly CommandLine _cli;

        public App() : this(CommandLine.Create())
        {
        }

        public App(CommandLine cli)
        {
            _cli = cli;
        }

        public string Run()
        {
            return ROT13Encoder.Encode(_cli.Arg);
        }
    }
}