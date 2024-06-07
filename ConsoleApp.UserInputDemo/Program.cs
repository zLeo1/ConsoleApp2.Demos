//Declare Variables
//

namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            string name = string.Empty;
            int age = 0;
            int retirementAge = 65;

            //Prompt for user info
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            age = Convert.ToInt32(Console.ReadLine());

            //Process Input
            int workingYearsRemaining = retirementAge - age;

            //Show Output
            Console.WriteLine($ "Hi {name} you have {workingYearsRemaining} years before you can live it up");
            Console.WriteLine("{0} you are {1} years old and still hot!", name, age);
        }
    }
}
