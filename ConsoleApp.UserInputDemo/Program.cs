//Declare Variables
//

namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            string? firstName = string.Empty;
            string lastName = string.Empty;
            int age;
            int retirementAge = 65;
            decimal salary;
            char gender = char.MinValue;
            bool isWorking = true;

            //Prompt for user info
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter your gender (m or f): ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Are you working? (true or false): ");
            isWorking = Convert.ToBoolean(Console.ReadLine());

            //Process Input
            int workingYearsRemaining = retirementAge - age;

            //Show Output
            Console.WriteLine($"Full name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Your salary is: {salary}");
            Console.WriteLine($"Your gender is: {gender}");
            Console.WriteLine($"Are you employed?: {isWorking}");
            Console.WriteLine($"Number of working years remaining: {workingYearsRemaining}");
        }
    }
}
