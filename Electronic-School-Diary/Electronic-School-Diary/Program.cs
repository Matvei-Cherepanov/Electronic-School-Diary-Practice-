using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_School_Diary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greating("Student");
            Greating("Teacher");
            Greating("Parent");
            Greating("Admin");
        }

        static void Greating(string role)
        {
            Console.WriteLine($"Hello {role}!");
        }
    }
}
