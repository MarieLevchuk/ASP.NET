using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            University university = new University();

            Console.WriteLine("---At school---");
            school.Learn();

            Console.WriteLine("\n---At university---");
            university.Learn();
        }
    }
}
