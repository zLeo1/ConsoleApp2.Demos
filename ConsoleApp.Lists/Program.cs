namespace ConsoleApp.Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare a list
            List<int> grades = new List<int>();
            List<string> students = new List<string>();
            int grade = 0;
            int gradeCount = 0;
            string name;
            int @continue;
            //var grades2 = new List<int>();  
            //List<int> grades3 = new();

            //Add values to a list
            //grades.Add(35);

            do
            {
                gradeCount += 1;
                Console.Write("Please enter a student's name: ");
                name = Console.ReadLine();
                students.Add(name);

                Console.Write("Please enter a student's grade: ");
                grade = Convert.ToInt32(Console.ReadLine());
                grades.Add(grade);
                //if (grade != -1)
                //{
                //    grades.Add(grade); 
                //}

                Console.Write("Do you wish to continue?(1 = yes | 2 = no): ");
                @continue = Convert.ToInt32(Console.ReadLine());

            } while (@continue == 1);

            //Print values in a list - For
            Console.WriteLine("Printing names via FOR loop");
            for (int i = 0; i < gradeCount; i++)
            {
                Console.WriteLine($"Student: {students[i]} Recieved:{grades[i]}%");
            }

            //Print values in a list - Foreach
            //Console.WriteLine("Printing names via FOREACH loop");
            //foreach (int g in grades) 
            //{
            //    Console.WriteLine(g);
            //}
        }
    }
}
