using static System.Console;

namespace ProjectedRaises
{
    internal class ProjectedRaises
    {
        static void Main(string[] args)
        {
            WriteLine();
            WriteLine("Welcome to our ProjectedRaises Application!");
            WriteLine();

            double projectedRaise = 0.04;

            double jacobSalary = 50000;
            double johnSalary = 60000;
            double kerrySalary = 70000;

            double jacobProjectedRaise = jacobSalary * projectedRaise;
            double johnProjectedRaise = johnSalary * projectedRaise;
            double kerryProjectedRaise = kerrySalary * projectedRaise;

            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine($"{"Employee",-10}{"Salary/Year",-20}{"ProjRaise/Yr",-20}");
            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine($"{"Jacob",-10}{jacobSalary,-20:C}{jacobProjectedRaise,-20:C}");
            WriteLine($"{"John",-10}{johnSalary,-20:C}{johnProjectedRaise,-20:C}");
            WriteLine($"{"Kerry",-10}{kerrySalary,-20:C}{kerryProjectedRaise,-20:C}");
            WriteLine(new string('-', 40)); // 40 dashes

            WriteLine();
            WriteLine($"Jacob's projected raise for Next Year is: {jacobProjectedRaise:C}");
            WriteLine($"John's projected raise for Next Year is: {johnProjectedRaise:C}");
            WriteLine($"Kerry's projected raise for Next Year is: {kerryProjectedRaise:C}");
            WriteLine();
        
            WriteLine();
            WriteLine("Welcome to our ProjectedRaisesInteractive Application!");
            WriteLine();

            try
            {
            WriteLine();
            WriteLine("Enter the salary for Jacob: ");
            double jacobSalary1 = double.Parse(ReadLine());
            WriteLine("Enter the salary for John: ");
            double johnSalary1 = double.Parse(ReadLine());
            WriteLine("Enter the salary for Kerry: ");
            double kerrySalary1 = double.Parse(ReadLine());
            
            // calculate the projected raise
            double jacobProjectedRaise1 = jacobSalary1 * projectedRaise;
            double johnProjectedRaise1 = johnSalary1 * projectedRaise;
            double kerryProjectedRaise1 = kerrySalary1 * projectedRaise;

            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine($"{"Employee",-10}{"Salary/Year",-20}{"ProjRaise/Yr",-20}");
            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine($"{"Jacob",-10}{jacobSalary1,-20:C}{jacobProjectedRaise1,-20:C}");
            WriteLine($"{"John",-10}{johnSalary1,-20:C}{johnProjectedRaise1,-20:C}");
            WriteLine($"{"Kerry",-10}{kerrySalary1,-20:C}{kerryProjectedRaise1,-20:C}");
            WriteLine(new string('-', 40)); // 40 dashes

            WriteLine();
            WriteLine($"Jacob's projected raise for Next Year is: {jacobProjectedRaise1:C}");
            WriteLine($"John's projected raise for Next Year is: {johnProjectedRaise1:C}");
            WriteLine($"Kerry's projected raise for Next Year is: {kerryProjectedRaise1:C}");
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
