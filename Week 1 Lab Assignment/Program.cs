using static System.Console;
namespace InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine();
            WriteLine("Welcome to our InchesToCentimeters Application!");
            WriteLine();
            double oneInch = 2.54;
            int inches = 3;
            //convert inches to centimeters
            double centimeters = inches * oneInch;
            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine($"{"inches:",-20}{inches,10:F2}");
            WriteLine($"{"centimeters:",-20}{centimeters,10:F2}");
            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine($"{inches} inches is {centimeters} centimeters.");
            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine();
            WriteLine();
            WriteLine("Now let's convert some inches to centimeters.");
            WriteLine();
            Write("Enter the number of inches: ");
            double input = double.Parse(ReadLine());
            //parse the input to a double
            double inchesToConvert;
            try
            {
                inchesToConvert = input;
                //convert inches to centimeters
                centimeters = inchesToConvert * oneInch;
                WriteLine(new string('-', 40)); // 40 dashes
                WriteLine($"{"inches:",-20}{inchesToConvert,10:F2}");
                WriteLine($"{"centimeters:",-20}{centimeters,10:F2}");
                WriteLine(new string('-', 40)); // 40 dashes
                WriteLine($"{inchesToConvert} inches is {centimeters} centimeters.");

            }
            catch (Exception ex)
            {
                WriteLine("You needed to enter a number. Now quitting.");
                WriteLine(ex.Message);
            }
            {
                WriteLine();
                WriteLine(new string('-', 40));
                WriteLine("Thanks for using our InchesToCentimeters Application!");
                WriteLine();
                WriteLine();
            }
        }
    }
}