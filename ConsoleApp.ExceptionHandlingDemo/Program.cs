namespace ConsoleApp.ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that takes a user's name as input and prints it to the screen.
            //Display an error message if an invalid input is recieved
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"You are {age} years old");
            }
            catch (Exception)
            {
                Console.WriteLine("Your Age value was incorrect, please try again");
                //throw;
            }
            finally
            {
                Console.WriteLine("***************-Thank You for using this program-*********************");
            }
            
        }
    }
}
