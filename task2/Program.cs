using System;

namespace task_DEV2
{
    class Entry
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intput string: ");
            string initStr = Console.ReadLine();

            if (initStr.Length > 0)
            {
                EvenIndexesStringCreator newStr = new EvenIndexesStringCreator(initStr);
                Console.WriteLine("String contains with only even indexes: {0} ", newStr.BuildSubstringOnlyOfEvenIndexes());
            }
            else
            {
                Console.WriteLine("Error.The string is empty");
            }
        }
    }
}
