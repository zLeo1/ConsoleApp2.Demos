namespace ConsoleApp.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************** - ARRAYS - ************************");

            //Tell me how many student and grade are to be entered
            Console.WriteLine("The number of grades to be entered: ");
            int numberOfGrades = Convert.ToInt32(Console.ReadLine());

            //Declare Fixed Size Array
            int[] grades = new int[numberOfGrades];
            string[] students = new string[numberOfGrades];

            //5 array indexes/adresses - 0,1,2,3,4
            //if n is the size of the array, then your array has addresses between 0 - n-1

            //Add Values to Fixed Size Array
            //grades[0] = 45;
            //grades[1] = 25;
            //grades[2] = 38;
            //grades[3] = 45;
            //grades[4] = 54;

            for (int i = 0; i < numberOfGrades; i++)
            {
                Console.Write("Please enter student's name: ");
                students[i] = Console.ReadLine();
                
                Console.Write("Please enter student's grade: ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Print Values From Fixed Size Array
            Console.WriteLine("The grades you have entered are: ");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine($"{students[i]}: recieved a: {grades[i]}%");    
            }

            //Declare Variable Sized Array
            //string[] studentNames = { "bob", "Frank", "Chris", "Etc..."};


            ////Add Values to Variable Size Array
            //for (int i = 0; i < studentNames.Length; i++)
            //{
            //    Console.Write("Please enter student name: ");
            //    studentNames[i] = Console.ReadLine();
            //}


            ////Print Values From Variable Size Array
            //Console.WriteLine("The names you have entered are: ");
            //for (int i = 0; i < studentNames.Length; i++)
            //{
            //    Console.WriteLine(studentNames[i]);
            //}
        }
    }
}
