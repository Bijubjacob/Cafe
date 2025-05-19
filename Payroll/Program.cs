using static System.Console;
namespace Payroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your name: ");
            string name = ReadLine();
            WriteLine($"OK, {name}, I will ask you some questions about your pay.");
            Write("Enter your hours worked: ");
            double hoursWorked = double.Parse(ReadLine());
            Write("Enter your pay rate: ");
            double payRate = double.Parse(ReadLine());
            double gross = hoursWorked * payRate;
            const double TAXRATE = 0.08;
            double taxes = gross * TAXRATE;
            double net = gross - taxes;
            try
            {
                WriteLine($"Here is your paycheck summary:   ");
                WriteLine($"{"Hours Worked:",-20}{hoursWorked,10:F2}");
                WriteLine($"{"Pay Rate:",-20}{payRate,10:F2}");
                WriteLine($"{"Gross Pay:",-20}{gross,10:C}");
                WriteLine($"{"Taxes:",-20}{taxes,10:C}");
                WriteLine($"{"Net Pay:",-20}{net,10:C}");
                WriteLine("Now you're rich ... kind of.");
            }
            catch (Exception ex)
            {
                WriteLine("You needed to enter numerical values. Now quitting.");
                WriteLine(ex.Message);
            }
        }
    }
}