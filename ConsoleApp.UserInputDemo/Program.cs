//Declare Variables
//

using System.Globalization;
using System.Xml.Serialization;

namespace ConsoleApp.UserInputDemo
{
    internal partial class Program
    {


        static void Main(string[] args)
        {
            char choice = char.MaxValue;

            string? firstName = string.Empty;
            string lastName = string.Empty;
            int age;
            DateOnly dob = new DateOnly();
            decimal salary;
            char gender = char.MinValue;
            bool isWorking = true;
            

            //Collections
            List<Person> persons = new List<Person>();

            while (choice != 'E')
            {
                //Prompt for user info
                Console.Write("Please enter your first name: ");
                firstName = Console.ReadLine();

                Console.Write("Please enter your last name: ");
                lastName = Console.ReadLine();

                Console.Write("Please enter your Date Of Birth(dd/mm/yyyy): ");
                dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);

                Console.Write("Please enter your salary: ");
                salary = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Please enter your gender (m or f): ");
                gender = Convert.ToChar(Console.ReadLine());

                Console.Write("Are you working? (true or false): ");
                isWorking = Convert.ToBoolean(Console.ReadLine());

                Person person = new Person(dob)
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Gender = gender,
                    IsWorking = isWorking,
                    Salary = salary
                };
                persons.Add(person);

                Console.WriteLine("C - Continue / E - Exit");
                choice = Convert.ToChar(Console.ReadLine());
            }

            foreach (var person in persons)
            {
                //Spacing
                Console.WriteLine($"********** - Full User Info - ***********");
                Console.WriteLine();

                //Show Output
                Console.WriteLine($"Full name: {person.ToString()}");
                Console.WriteLine($"Age: {person._age}");
                Console.WriteLine($"Your salary is: {person.Salary.ToString("C")}");//Or can use {salary.ToString:C}
                Console.WriteLine($"Your gender is: {person.Gender}");
                Console.WriteLine($"Are you employed?: {person.IsWorking}");
                Console.WriteLine($"Number of working years remaining: {person.GetNumberOfWorkingYearsRemaining()}");
                Console.WriteLine($"Estimated Retirement Year: {person.GetEstimatedRetirementDate().Year}");

                //Spacing
                Console.WriteLine();
            }

            
           
            
        }
    }
}
