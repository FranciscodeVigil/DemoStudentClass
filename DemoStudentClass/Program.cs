using System;

namespace DemoStudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student molly = new Student("Molly Cat", 1234);

            Console.WriteLine("Molly's Id Number: {0}", molly.GetIdNumber());
            Console.WriteLine("Molly's Name: {0}", molly.GetName());

            Student bella = new Student("Bella");

            Console.WriteLine("Bella's Id Number: {0}", bella.GetIdNumber());
            Console.WriteLine("Bella's Name: {0}", bella.GetName());

            Student kitkat = new Student("KitKat");

            Console.WriteLine("kitKat's Id Number: {0}", kitkat.GetIdNumber());
            Console.WriteLine("kitKat's Name: {0}", kitkat.GetName());

        }
    }
}
