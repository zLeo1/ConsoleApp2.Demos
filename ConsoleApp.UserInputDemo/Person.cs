//Declare Variables
//

namespace ConsoleApp.UserInputDemo
{
    internal partial class Program
    {
        public class Person
        {
            //Properties
            public required string FirstName { get; set; }
            public required string LastName { get; set; }
            public DateOnly DateOfBirth { get; init; }
            public decimal Salary { get; set; }
            public char Gender { get; set; }
            public bool IsWorking { get; set; }

            //Fields
            public readonly int _age;

            public Person(DateOnly dob)
            {
                _age = DateTime.Now.Year - dob.Year;
                DateOfBirth = dob;
            }


            //public int GetAge()
            //{
            //    return DateTime.Now.Year - DateOfBirth.Year;
            //}

            public int GetNumberOfWorkingYearsRemaining()
            {
                return Constants.RETIREMENT_AGE - _age;
            }

            public DateOnly GetEstimatedRetirementDate()
            {
                return DateOnly.FromDateTime(DateTime.Now.AddYears(GetNumberOfWorkingYearsRemaining()));
            }

            public override string ToString()
            {
                return $"{FirstName} {LastName}";
            }

            public int GetAge()
            {
                return _age;
            }

        }
    }
}
