namespace ROT13Console
{
    public class App
    {
        public string Run()
        {
            const string message = "hello";
            return ROT13Encoder.Encode(message);
        }
    }
}