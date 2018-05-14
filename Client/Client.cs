using System;
using WebService_Task11;

namespace Client
{
    class Client
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the day: ");
                int day = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the month: ");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the year: ");
                int year = int.Parse(Console.ReadLine());

                DaysADCounter webServis = new DaysADCounter();
                Console.WriteLine("Count of days from Anno Domini to the entered date: " + webServis.CalculateDaysFromAD(day, month, year));
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
