using System;

namespace task_DEV2
{
    class Entry
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intput string: ");
            string InitStr = Console.ReadLine();

            if (InitStr.Length > 0)
            {
                CreatorStringOnlyOfEvenIndexes NewStr = new CreatorStringOnlyOfEvenIndexes(InitStr);
                Console.WriteLine("String contains with only even indexes: {0} ", NewStr.BuildSubstringOnlyOfEvenIndexes());
            }
            else
            {
                Console.WriteLine("Error.The string is empty");
            }
        }
    }
}
