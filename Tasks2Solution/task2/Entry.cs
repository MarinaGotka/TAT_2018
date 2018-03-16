using System;

namespace task_DEV2
{
    class Entry
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intput string: ");
            string initStr = Console.ReadLine();

            try
            {
                EvenIndexesStringCreator initString = new EvenIndexesStringCreator(initStr);
                initString.BuildSubstringOnlyOfEvenIndexes();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
