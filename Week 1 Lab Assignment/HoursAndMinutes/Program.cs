using static System.Console;
namespace HoursAndMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine();
            WriteLine("Welcome to our Hours and Minutes Application!");
            WriteLine();
        try
            {
            WriteLine("Please enter the total minutes: ");
            int minutes = int.Parse(ReadLine());

            // calculate the total hours and remaining minutes
            int hours = minutes / 60;
            
            // calculate the remaining minutes
            int remainingMinutes = minutes % 60;
            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine($"{"Total Minutes:",-20}{minutes,10}");
            WriteLine($"{"Hours:",-20}{hours,10}");
            WriteLine($"{"Minutes:",-20}{remainingMinutes,10}");
            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine($"The total minutes is: {minutes} minutes");
            WriteLine($"The total hours is: {hours} hours");
            WriteLine($"The remaining minutes is: {remainingMinutes} minutes");
            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine();
            WriteLine();
            }
            catch (Exception ex)
            {
            WriteLine("You needed to enter a number. Now quitting.");
            WriteLine(ex.Message);
            }
        }
    }
}