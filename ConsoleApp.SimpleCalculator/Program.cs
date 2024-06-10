namespace ConsoleApp.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Variables
            int choice = 0;
            int num1, num2 = 0;

            while (choice != -1)
            {
                try
                {
                    //Welcome message
                    Console.Clear();
                    Console.WriteLine("**********- Welcome to the simple calculator -**********");
                    Console.WriteLine();
                    Console.WriteLine("Please select an operation(-1 to exit)");
                    Console.WriteLine("1 - Addition");
                    Console.WriteLine("2 - Subtraction");
                    Console.WriteLine("3 - Multiplication");
                    Console.WriteLine("4 - Division");
                    Console.WriteLine("5 - Fibonacci Sequence");
                    Console.WriteLine();
                    Console.Write("Choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == -1)
                    {
                        break;
                    }

                    //Prompt User Input
                    Console.Write("Please enter the first number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    //Prompt for second number
                    Console.Write("Please enter the second number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

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
                            throw new Exception("Invalid Menu Item Selected.");
                    }

                    //Print Answer output
                    Console.WriteLine($"Your Answer is: {answer}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot Divide by zero");
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("******- Thank you for using the simple calculator program -********");
        }
    }
}
