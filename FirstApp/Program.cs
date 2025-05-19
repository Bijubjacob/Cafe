using static System.Console;
namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello, World!");
            Write("Enter your name: ");
            string name = ReadLine();
            WriteLine($"It's nice to meet you, {name}!");
            Write("How old are you? ");
            int age = int.Parse(ReadLine());
            int ageInMonths = age * 12;
            WriteLine($"I see you are {age} years old, which is {ageInMonths} months.");
            double sqrtAgeInMonths = Math.Sqrt(ageInMonths);
            // The Math.Sqrt method returns the square root of a number.
            // The result is a double, so we need to format it to 3 decimal places.
            // The 0:F3 format specifier means to format the number with 3 decimal places.
            // The 0 means to use the first argument (sqrtAgeInMonths) as the number to format.
            // The F3 means to format the number as a fixed-point number with 3 decimal places.
            // The 10:F3 format specifier means to format the number with 3 decimal places and to use a width of 10 characters.
            WriteLine($"The square root of your age in months is {sqrtAgeInMonths,0:F3}.");
        }
    }
}