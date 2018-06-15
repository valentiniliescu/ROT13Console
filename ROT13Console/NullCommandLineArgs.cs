namespace ROT13Console
{
    public class NullCommandLineArgs : ICommandLineArgs
    {
        public NullCommandLineArgs(string arg)
        {
            Arg = arg;
        }

        public string Arg { get; }
    }
}