using System.Security.Cryptography.X509Certificates;
using ConsoleApp.ClassesDemo.Classes.PersonDemo;
using ConsoleApp.ClassesDemo.Classes.ShapeDemo;

namespace ConsoleApp.ClassesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************** Classes And Objects ******************************");
            Person person;
            Person baby = new Person();
            baby.LastName = "Thompson";
            baby.FirstName = "Theresa";
            baby.DateOfBirth = new DateOnly(2023,10,29);

            baby.PrintFullName();
            baby.PrintInitials();
            baby.GenerateTaxNumber();
            var taxNumber = baby.GetTaxNumber();
            Console.WriteLine(taxNumber);

            Console.WriteLine();

            var person1 = new Person("Zack", "Leonardo", new DateOnly(1974, 03, 23));
            person1.PrintFullName();
            person1.PrintInitials();

            Console.WriteLine();

            var person2 = new Person("Bob", "Jangles", "567 85 9556");
            person2.PrintFullName();
            person2.PrintInitials();

            person2.GenerateTaxNumber();
            var taxNumber2 = person2.GetTaxNumber();
            Console.WriteLine(taxNumber2);

            var personId = person2.GetIdNumber();
            Console.WriteLine(personId);

            Console.WriteLine();

            var teacher = new Teacher();
            teacher.PrintFullName();
            teacher.LastName = "Mrs.";
            teacher.FirstName = "Jeanette";
            teacher.DateOfBirth = new DateOnly(1985, 04, 15);
            teacher.PrintFullName();
            teacher.PrintInitials();

            teacher.GenerateTaxNumber();
            var taxNumberT = teacher.GetTaxNumber();
            Console.WriteLine(taxNumberT);

            teacher.GenerateTeacherIdNumber();
            var teacherId = teacher.GetIdNumber();  
            Console.WriteLine(teacherId);

            Console.WriteLine();

            Student student = new();
            student.PrintFullName();
            student.LastName = "Frank";
            student.FirstName = "Thomp";
            student.DateOfBirth = new DateOnly(2001, 12, 04);
            student.PrintFullName();
            student.PrintInitials();

            student.GenerateTaxNumber();
            var taxNumberS = teacher.GetTaxNumber();
            Console.WriteLine(taxNumberS);

            student.GenerateStudentIdNumber();
            var studentId = student.GetIdNumber();
            Console.WriteLine(studentId);


            Console.WriteLine();


            //Polygon polygon = new Polygon();//Compiler Error    
            Rectangle rect = new Rectangle(10, 50);
            var rArea = rect.Area();
            Console.WriteLine($"The area of the rectangle is: {rArea}");

            Square square = new Square(5);
            var sArea = square.Area();
            Console.WriteLine($"The area of the square is: {sArea}");

            Triangle tri = new Triangle(10, 20);
            var tArea = tri.Area();
            Console.WriteLine($"The area of the triangle is: {tArea}");

            Cuboid cube = new Cuboid(10, 20, 10);
            var cArea = cube.Area();
            var cPer = cube.Perimeter();
            var cVol = cube.Volume();
            Console.WriteLine($"Cuboid Area: {cArea} Perimeter: {cPer} Volume: {cVol}");

            Sphere sphere = new Sphere(15);
            var sphereCir = sphere.Circumference();
            var sphereVol = sphere.Volume();
            Console.WriteLine($"{nameof(Sphere)} Circumference: {sphereCir} Volume: {sphereVol}");
        }
    }
}
