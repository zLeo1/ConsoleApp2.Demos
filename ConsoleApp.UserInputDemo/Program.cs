//Declare Variables
//

using System.Globalization;

namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            const int retirementAge = 65;

            string? firstName = string.Empty;
            string lastName = string.Empty;
            int age;
            DateOnly dob = new DateOnly();
            decimal salary;
            char gender = char.MinValue;
            bool isWorking = true;

            //Prompt for user info
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Please enter your Date Of Birth(dd/mm/yyyy): ");
            dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);
            age = DateTime.Now.Year - dob.Year;

            Console.Write("Please enter your salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter your gender (m or f): ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Are you working? (true or false): ");
            isWorking = Convert.ToBoolean(Console.ReadLine());

            //Process Input
            int workingYearsRemaining = retirementAge - age;
            var estimatedRetirementYear = DateTime.Now.AddYears(workingYearsRemaining);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"********** - Full User Info - ***********");
            //Show Output
            Console.WriteLine($"Full name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Your salary is: {salary:C}");//Or can use {salary.ToString("C")}
            Console.WriteLine($"Your gender is: {gender}");
            Console.WriteLine($"Are you employed?: {isWorking}");
            Console.WriteLine($"Number of working years remaining: {workingYearsRemaining}");
            Console.WriteLine($"Estimated Retirement Year: {estimatedRetirementYear.Year}");
        }
    }
}
