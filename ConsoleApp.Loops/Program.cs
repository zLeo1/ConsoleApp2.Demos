namespace ConsoleApp.Loops
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Simple for loop example
            //Print Hello World 10 times
            //Console.Write("How Many Loops to complete?");
            //int numTimes = Convert.ToInt32(Console.ReadLine());

            //Simple for loop
            //for (int i = 0; i < numTimes; i++)
            //{
            //    Console.WriteLine($"Hello World - {i}");
            //}

            //simple while loop
            int sum = 0;
            int num = 0;

            do
            {
                Console.Write("Pick a number to be summed up (Enter -1 to stop or exit): ");
                num = Convert.ToInt32(Console.ReadLine());
                if(num != -1)
                    sum += num;
            } while (num != -1);

            Console.WriteLine($"The Sum of your numbers is: {sum}");
        }
    }
}
