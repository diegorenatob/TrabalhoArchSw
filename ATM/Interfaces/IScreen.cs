namespace Interfaces
{
    public interface IScreen
    {
        void DisplayDollarAmount(decimal amount);
        void DisplayMessage(string message);
        void DisplayMessageLine(string message);
    }
}