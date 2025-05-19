using static System.Console;
namespace Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine();
            WriteLine("Welcome to our Eggs Application!");
            WriteLine();
            try
            {
                int Chicken1Eggs, Chicken2Eggs, Chicken3Eggs, Chicken4Eggs;

                WriteLine("Please enter the number of eggs for Chicken 1 in a Year: ");
                Chicken1Eggs = int.Parse(ReadLine());
                WriteLine("Please enter the number of eggs for Chicken 2 in a Year: ");
                Chicken2Eggs = int.Parse(ReadLine());
                WriteLine("Please enter the number of eggs for Chicken 3 in a Year: ");
                Chicken3Eggs = int.Parse(ReadLine());
                WriteLine("Please enter the number of eggs for Chicken 4 in a Year: ");
                Chicken4Eggs = int.Parse(ReadLine());

                // calculate the total eggs
                int totalEggs = Chicken1Eggs + Chicken2Eggs + Chicken3Eggs + Chicken4Eggs;
                int dozenEggs = 12;
                int dozenEggsPerYear = totalEggs / dozenEggs;
                int remainingEggs = totalEggs % dozenEggs;

                WriteLine(new string('-', 40)); // 40 dashes
                WriteLine($"{"Chicken 1:",-20}{Chicken1Eggs,10}");
                WriteLine($"{"Chicken 2:",-20}{Chicken2Eggs,10}");
                WriteLine($"{"Chicken 3:",-20}{Chicken3Eggs,10}");
                WriteLine($"{"Chicken 4:",-20}{Chicken4Eggs,10}");
                WriteLine(new string('-', 40)); // 40 dashes
                WriteLine($"{"Total Eggs in a Year:",-20}{totalEggs,10}");
                WriteLine(new string('-', 40)); // 40 dashes
                WriteLine($"Total eggs in a year is: {totalEggs} eggs");
                WriteLine($"Total eggs in a year is: {dozenEggsPerYear} dozens and {remainingEggs} eggs");
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