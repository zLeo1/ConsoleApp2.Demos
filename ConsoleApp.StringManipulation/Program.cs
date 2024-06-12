namespace ConsoleApp.StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialize with regular string literal
            string s1 = "This is a literal string";
            String s2 = "This is a literal string";

            //Console.WriteLine($"s1: {s1}");
            Console.WriteLine($"{nameof(s1)}: {s1}");
            Console.WriteLine($"{nameof(s2)}: {s2}");

            //Declare without initializing(possible null exception)
            string s3;
            //Console.WriteLine($"{nameof(s3)}: {s3}");

            //Initialize to null(possible null exception)
            string? s4 = null; //using the quetion mark will allow it to be null ar nullable
            Console.WriteLine($"{nameof(s4)}: {s4}");

            //Itialize to an empty string
            string s5 = string.Empty;//Safer option...prevents accidental empty character 
            string s6 = "";
            Console.WriteLine($"{nameof(s5)}: {s5}");
            Console.WriteLine($"{nameof(s6)}: {s6}");

            //Escape sequences and characters
            //she said, "I have your phone" - quote and displaying quotation marks
            string sentence = "She said, \"I have your phone\" \r\n This is the next line";// to display special characters place \ in front I.e \", \r\n - newline
            Console.WriteLine($"{nameof(sentence)}: {sentence}");

            //Verbatim string literal
            string oldPath = "c:\\program files\\program folder\\program.exe";// need escape character \ for backslash hence \\
            string newPath = @"c:\program files\program folder\program.exe";// @ before string allows verbatim string
            Console.WriteLine($"{nameof(oldPath)}: {oldPath}");
            Console.WriteLine($"{nameof(newPath)}: {newPath}");

            //use Const to prevent modification of a string
            const string path = @"C:\Program Files\...";// Kepps string constant without change
            Console.WriteLine($"{nameof(path)}: {path}");
            //path = newPath;//can't change constant - uncomment to see
            //s1 = newPath;//can change variable

            //Raw string literals
            string rawLiteral = """ \sfd '' "This is a literal string" """;//Hitting Double quotes 3 times allow us to put anything inside it
            string rawLiteral2 = """ 
                                \sfd '' "This is a Multi line literal string"
                                This is a new line
                                path = C:\Program Files\Program\Start.exe
                                """;//triple quotes need to be on their own line
            Console.WriteLine($"{nameof(rawLiteral)}: {rawLiteral}");
            Console.WriteLine($"{nameof(rawLiteral2)}: {rawLiteral2}");

            //Review concatenation and interpolation
            //s1 = s1 + s2;
            //s1 += s2;//or shorthand
            string newString = $"{s1} {s2} some other text";
            string newString2 = string.Format("Literal string {0} {1}", s1,s2);
            Console.WriteLine($"{nameof(newString)}: {newString}");
            Console.WriteLine($"{nameof(newString2)}: {newString2}");


            /* String Manipulation methods and properties. sometimes it is just assessment*/

            //Substrings
            string subString = s1.Substring(5);
            Console.WriteLine($"{nameof(subString)} : {subString}");
            subString = s1.Substring(5, 5);
            Console.WriteLine($"{nameof(subString)} : {subString}");    

            //Null or Empty checks
            //find the length of a string
            Console.WriteLine($"{nameof(s1)} has a length of {s1.Length}");
            //Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");//Will cause Null Exception
            //Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");//Emmpty string will be 0
            Console.WriteLine($"{nameof(s6)} has a length of {s6.Length}");

            if(!string.IsNullOrEmpty(s4))
            {
                Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");
            }

            if (!string.IsNullOrEmpty(s5))
            {
                Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
            }

            //Splitting strings
            var splitStrings = s2.Split(' ');
            for (int i = 0; i < splitStrings.Length; i++)
            {
                Console.WriteLine($"{nameof(splitStrings)} : {splitStrings[i]}");
            }

            //Replace
            string replacement1 = s1.Replace('s','$');
            string replacement2 = s1.Replace("string","chicken");
            Console.WriteLine($"{nameof(replacement1)} : {replacement1}");
            Console.WriteLine($"{nameof(replacement2)} : {replacement2}");

            //Convert to string
            string salary = 54564121.54.ToString();
            int value = 354541215;
            string strValue = value.ToString();

            //Changing formatting
            Console.WriteLine($"{nameof(salary)} : {salary:C}");
            Console.WriteLine(nameof(salary) + ":" + value.ToString("C"));

            //String comparison
            Console.ReadLine(); 
        }
    }
}
