using System;

namespace DemoStudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student molly = new Student("Molly Cat", 1234);

            Console.WriteLine("Molly's Id Number: {0}", molly.IdNumber);
            Console.WriteLine("Molly's Name: {0}", molly.Name);
            molly.Score1 = 100;
            molly.Score2 = 80;
            Console.WriteLine("Molly's Average Score: {0}", molly.AverageScore);
            Console.WriteLine("Molly's High Score: {0}", molly.HighScore);


        }
    }
}
