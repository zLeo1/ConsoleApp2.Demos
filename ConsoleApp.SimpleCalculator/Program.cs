namespace ConsoleApp.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("**********- Welcome to the simple calculator -**********");

            //Show calculator options
            Console.WriteLine("****- Operations Menu -*****");
            Console.WriteLine();

            Console.WriteLine("Please select an operation(-1 to exit)");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - FibonacciSequence");
            Console.WriteLine();

            Console.Write("Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != -1)
            {
                //Prompt User Input
                Console.Write("Please enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                //Prompt for second number
                Console.Write("Please enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                int answer = 0;
                //Decide which operation is needed based on option selected
                switch (choice)
                {
                    case 1:
                        answer = num1 + num2;
                        Console.WriteLine($"{num1} + {num2}");
                        break;
                    case 2:
                        answer = num1 - num2;
                        Console.WriteLine($"{num1} - {num2}");
                        break;
                    case 3:
                        answer = num1 * num2;
                        Console.WriteLine($"{num1} * {num2}");
                        break;
                    case 4:
                        answer = num1 / num2;
                        Console.WriteLine($"{num1} / {num2}");
                        break;
                    case 5:
                        for (int i = num1; i <= num2; i++)
                        {
                            answer += i;
                        }
                        Console.WriteLine($"Sum of numbers from {num1} to {num2}");
                        break;
                    default:
                        Console.WriteLine("Not a Valid Choice!");
                        break;
                }
                //Print output

                Console.WriteLine($"Your Answer is: {answer}");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                Console.Clear();
                //Show calculator options
                Console.WriteLine("****- Operations Menu -*****");
                Console.WriteLine();

                Console.WriteLine("Please select an operation(-1 to exit)");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - FibonacciSequence");
                Console.WriteLine();
                Console.Write("Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Thank you for using the simple calculator program");
            Environment.Exit(0);
        }
    }
}
