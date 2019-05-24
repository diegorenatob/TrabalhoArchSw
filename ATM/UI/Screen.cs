using Interfaces;
using static System.Console;

namespace UI
{
    public class Screen : IScreen
    {
        public void DisplayMessage(string message)
        {
            Write(message);
        }

        public void DisplayMessageLine(string message)
        {
            WriteLine(message);
        }

        public void DisplayDollarAmount(decimal amount)
        {
            Write(amount.ToString("$#.00"));
        }
    }
}