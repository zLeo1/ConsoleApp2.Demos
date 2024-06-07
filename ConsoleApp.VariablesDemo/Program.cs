namespace ConsoleApp.VariablesDemo
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string name = "Zack";
            Console.WriteLine(name);
            Console.WriteLine("Hi, I am " + name);//Concatenation
            Console.WriteLine($"They call me {name}");//String Interpolation - Starts with $ symbol, variable in braces
            Console.WriteLine("I was given the name {0}", name);//Formatted String 
        }
    }
}
