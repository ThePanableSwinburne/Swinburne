using System;

namespace VariablesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name: ");
            var firstName = Console.ReadLine();
            
            Console.WriteLine("Enter surname: ");
            var surname = Console.ReadLine();
            
            Console.WriteLine("Enter StudentID: ");
            var studentID = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter year of birth: ");
            var birthYear = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter current year: ");
            var currentYear = Convert.ToInt32(Console.ReadLine());

            var age = currentYear - birthYear;
            Console.WriteLine($"{firstName} {surname} \n{age}");

        }
    }
}