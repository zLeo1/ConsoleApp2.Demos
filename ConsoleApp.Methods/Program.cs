using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************- Methods -************************");

            //Void Methods - no values returned - just completes a task
            void PrintName()
            {
                Console.WriteLine($"Zack");   
            }

            //Value returning methods
            int GetFiveYearsAgo()
            {
                int year = DateTime.Now.AddYears(-5).Year;
                return year;
            }

            //Methods with Parameters
            void PrintNameWithParams(string name)
            {
                Console.WriteLine("Your name is: " + name);
            }

            int GetYearDifferenceWithParams(int year)
            {
                int yearDifference  = DateTime.Now.Year - year;
                return yearDifference;
            }

            //Methods with optional parameters
            int GetFutureOrPastYears(int numberOfYears = 0)
            {
                var year = DateTime.Now.AddYears(numberOfYears).Year;
                return year;    
            }

            //Methods with nullable parameters
            void PrintNameNullableParam(string? name, int? count)
            {
                //if(string.IsNullOrEmpty(name))
                //{
                //    name = "No Name";
                //}

                //if(!count.HasValue)
                //{
                //    count = 1;
                //}

                //Shorthand Null checks in 2 lines instead of the 8 above
                name ??= "Default Name";// ??=  -Null Coalescing Operator
                count ??= 1;// ??=  -Null Coalescing Operator

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Your name is: " + name);
                }
            }


            //Function Calls
            //PrintName();
            //int fiveYearsAgo = GetFiveYearsAgo();
            //Console.WriteLine($"Five years ago: {fiveYearsAgo}");

            //Console.WriteLine($"Enter your name: ");
            //string name = Console.ReadLine();

            //Console.WriteLine($"Enter a year: ");
            //int pastYear = Convert.ToInt32(Console.ReadLine());
            //int yearAgo = GetYearDifferenceWithParams(pastYear);

            //Console.WriteLine($"Enter number of years in he future or the past: ");
            //int numberOfYears = Convert.ToInt32(Console.ReadLine());
            //var pastYear1 = GetFutureOrPastYears(0);
            //var pastYear2 = GetFutureOrPastYears(numberOfYears);

            ////Output
            //PrintNameWithParams(name);
            //Console.WriteLine($"This was {yearAgo} years ago");
            //Console.WriteLine($"The year is: {pastYear1}");
            //Console.WriteLine($"The year is: {pastYear2}");
            PrintNameNullableParam(null, null);
            PrintNameNullableParam("JohnBoy", 5);
        }
    }
}
