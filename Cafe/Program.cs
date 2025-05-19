using static System.Console;
namespace Cafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to our coffee shop!");
            WriteLine();
            string firstItemName, secondItemName;
            double firstPrice, secondPrice;
            int firstQuantity, secondQuantity;
            Write("Enter the name of the first item: ");
            firstItemName = ReadLine().Trim();//get rid of leading and trailing spaces
            try
            {
                Write($"Enter the price of the {firstItemName}: ");
                firstPrice = double.Parse(ReadLine());
                Write($"Enter the quantity of the {firstItemName}: ");
                firstQuantity = int.Parse(ReadLine());
            } catch (Exception ex)
            {
                WriteLine("The price and quantity must be numbers! Exiting now.");
                return; //exiting the main function - exit the program
            }
            WriteLine();
            Write("Enter the name of the second item: ");
            secondItemName = ReadLine().Trim();//get rid of leading and trailing spaces
            try
            {
                Write($"Enter the price of the {secondItemName}: ");
                secondPrice = double.Parse(ReadLine());
                Write($"Enter the quantity of the {secondItemName}: ");
                secondQuantity = int.Parse(ReadLine());
            }
            catch (Exception ex)
            {
                WriteLine("The price and quantity must be numbers! Exiting now.");
                return; //exiting the main function - exit the program
            }
            double firstTotal, secondTotal, subTotal, salesTax, finalTotal;
            const double TAXRATE = 0.08;
            firstTotal = firstPrice * firstQuantity;
            secondTotal = secondPrice * secondQuantity;
            subTotal = firstTotal + secondTotal;
            salesTax = subTotal * TAXRATE;
            finalTotal = subTotal + salesTax;
            WriteLine();
            WriteLine("Receipt");
            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine($"{"Item",-10}{"Quantity",-10}{"Price",10}{"Total",10}");
            WriteLine($"{firstItemName,-10}{firstQuantity,-10}{firstPrice,10:C}{firstTotal,10:C}");
            WriteLine($"{secondItemName,-10}{secondQuantity,-10}{secondPrice,10:C}{secondTotal,10:C}");
            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine($"{"Subtotal:",-30}{subTotal,10:C}");
            WriteLine($"{"Sales Tax:",-30}{salesTax,10:C}");
            WriteLine($"{"Final Total:",-30}{finalTotal,10:C}");
            WriteLine(new string('-', 40)); // 40 dashes
            WriteLine("Thank you for your purchase!");
        }
    }
}