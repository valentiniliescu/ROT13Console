using System.Linq;

namespace ROT13Console
{
    public static class ROT13Encoder
    {
        public static string Encode(string message)
        {
            return string.Concat(message.Select(x =>
                x >= 'a' && x <= 'z'
                    ? (char) ((x - 'a' + 13) % 26 + 'a')
                    : (x >= 'A' && x <= 'Z'
                        ? (char) ((x - 'A' + 13) % 26 + 'A')
                        : x)));
        }
    }
}