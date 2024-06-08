namespace ConsoleApp.Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Plaese enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Plaese enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            /*
             * Math Opertions and Operators
             **/
            //Addition
            int sum = num1 + num2;

            //Multiplication
            int product = num1 * num2;

            //Division
            int quotient = num1 / num2; 

            //Subtraction
            int difference = num1 - num2;   

            //Modulos
            int mod = num1 % num2;

            Console.WriteLine();
            Console.WriteLine("***************** Math Results ******************");
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Differemce: {difference}");
            Console.WriteLine($"Remainder: {mod}");
            Console.WriteLine();
            Console.WriteLine("***************** END Math Results ******************");

            /*
             * Logic operations and operators
             */
            bool isGreaaterThan = num1 > num2;
            bool isLessThan = num1 < num2;  
            bool isEqualTo = num1 == num2;  
            bool isGreaterThanOrEqualTo = num1 >= num2;
            bool isLessThanOrEqualTo = num1 <= num2;    
            bool isNotEqualTo = num1 != num2;
            Console.WriteLine();    
            Console.WriteLine("***************** Logic Results ******************");
            Console.WriteLine();
            Console.WriteLine($"Greater Than: {isGreaaterThan}");
            Console.WriteLine($"Less Than: {isLessThan}");
            Console.WriteLine($"Equal To: {isEqualTo}");
            Console.WriteLine($"Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
            Console.WriteLine($"Less Than Or Equal TO: {isLessThanOrEqualTo}");
            Console.WriteLine($"Not Equal To: {isNotEqualTo}");
            Console.WriteLine();
            Console.WriteLine("***************** END Logic Results ******************");

            /*
             * Assignment operations and operators
             */
            Console.WriteLine();
            Console.Write("Please enter a 3rd number: ");
            int randomValue = Convert.ToInt32(Console.ReadLine());

            //int increaseValue = num1 + randomValue;
            Console.WriteLine();
            Console.WriteLine("***************** Assignment Results ******************");
            Console.WriteLine();
            num1 += randomValue;
            Console.WriteLine($"Num1 Increased by {randomValue}: {num1}");
            num1 -= randomValue;
            Console.WriteLine($"Num1 Decreased by {randomValue}: {num1}");
            num1 /= randomValue;
            Console.WriteLine($"Num1 Divided by {randomValue}: {num1}"); 
            num1 %= randomValue;
            Console.WriteLine($"Num1 Mod by {randomValue}: {num1}");
            num1 *= randomValue;
            Console.WriteLine($"Num1 Multiplied by {randomValue}: {num1}");
            Console.WriteLine();
            Console.WriteLine("***************** END Assignment Results ******************");
            Console.WriteLine();
        }
    }
}
