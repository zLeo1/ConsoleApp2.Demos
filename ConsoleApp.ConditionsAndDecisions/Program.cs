namespace ConsoleApp.ConditionsAndDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt for input
            Console.Write("Please enter student's grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            //Simple If...Else Statement / Decide to print pass or fail based on input
            Console.WriteLine("************************ Simple If Results *******************************");
            if (grade > 50) 
            {
                Console.WriteLine("Student has passed");
            }
            else
            {
                Console.WriteLine("Student has failed");
                Console.WriteLine("Please refer student to student affair's office");
            }
            Console.WriteLine("************************ Simple If Results END *******************************");
            Console.WriteLine();
            //Complex If...Else If Statement / Decide to print a letter or fail based on input
            Console.WriteLine("************************ Complex If...Else If Results *******************************");
            if (grade < 60)
            {
                Console.WriteLine("Grade: F");
            }
            else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine("Grade: D");
            }
            else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine("Grade: C");
            }
            else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("Grade: B");
            }
            else if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("Grade: A");
            }
            else
            {
                Console.WriteLine("Incorrect number given please try again");
            }
            
            Console.WriteLine("************************ Complex If...Else If Results END *******************************");


            Console.WriteLine();
            Console.WriteLine("************************ Ternary Operator Results *******************************");

            string passStatus = grade > 90 ? "Student Honor Roll" : "Student Sucks big balls";
            Console.WriteLine($"Student Status is: {passStatus}");

            Console.WriteLine("************************ Ternary Operator Results END *******************************");
            
            Console.WriteLine("************************ Switch Statement Results *******************************");
            /*
             * Write a program to accept an integer as the day of the week and print appropriate message below
             * 1-Sunday
             * 2-Monday
             * 3-Tuesday
             * 4-Wednesday
             * 5-Thursday
             * 6-Friday
             * 7-Saturday
             * */
            Console.Write("Please a number for weekday: ");
            int dayOftheWeek = Convert.ToInt32(Console.ReadLine());
            switch (dayOftheWeek)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Not a valid Entry");
                    break;
            }
            Console.WriteLine("************************ Switch Statement Results END *******************************");




            Console.WriteLine("Thank you for using this program");
            
        }
    }
}

