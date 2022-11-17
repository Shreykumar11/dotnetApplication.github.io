using Addition;
using Subtraction;
using Multiplication;
using Division;

namespace MainSolution
{
    public class Calculator
    {
        public static void Main()
        {
            int choice = 0, value;
            while (choice != 5)
            {
                Console.WriteLine("\t\t\tMENU");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Add a = new Add();
                        value = a.Main(2,5);
                        Console.WriteLine("Addition = {0}", value);
                        break;
                    case 2:
                        Subtract b = new Subtract();
                        value = b.Main(45,65);
                        Console.WriteLine("Subtraction = {0}", value);
                        break;
                    case 3:
                        Multiply c = new Multiply();
                        value = c.Main(45,78);
                        Console.WriteLine("Mltiplication = {0}", value);
                        break;
                    case 4:
                        Divide d = new Divide();
                        value = d.Main(33,3);
                        Console.WriteLine("Division = {0}", value);
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("INVALID INPUT !!");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
