using Interfaces;
using static System.Console;

namespace Domain
{
    public class Keypad : IKeypad
    {
        public int GetInput()
        {
            int.TryParse(ReadLine(), out int output);
            return output;
        }
    }
}
