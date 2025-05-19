using static System.Console;
namespace MalcolmMovers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine();
            WriteLine("Welcome to Malcolm Movers Estimator!");
            WriteLine();
            int BaseRate = 200;
            int PerhourRate = 150;
            int PerMileRate = 2;
        try
            {
            WriteLine("Please enter the number of hours for the move: ");
            int hours = int.Parse(ReadLine());
            WriteLine("Please enter the number of miles for the move: ");
            int miles = int.Parse(ReadLine());

            //calculate the total cost
            int totalCost = BaseRate + (PerhourRate * hours) + (PerMileRate * miles);
            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine($"{"Base Rate:",-20}{BaseRate,10:C}");
            WriteLine($"{"Per Hour Rate:",-20}{PerhourRate,10:C}");
            WriteLine($"{"Per Mile Rate:",-20}{PerMileRate,10:C}");
            WriteLine($"{"Hours:",-20}{hours,10}");
            WriteLine($"{"Miles:",-20}{miles,10}");
            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine($"{"Total Cost:",-20}{totalCost,10:C}");
            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine($"The total cost for the move is: {totalCost:C}");
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