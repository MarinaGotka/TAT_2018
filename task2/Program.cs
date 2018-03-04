using System;

namespace task_DEV2
{
    class Entry
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Intput string: ");
            string str = Console.ReadLine();

            if (str.Length > 0)
            {
                CreatorStringOnlyOfEvenIndexes strEven = new CreatorStringOnlyOfEvenIndexes(str);
                string res = strEven.BuildSubstringOnlyOfEvenIndexes();
                Console.WriteLine("String contains with only even indexes: {0} ", res);
            }
            else
            {
                Console.WriteLine("Error.The string is empty");
            }
        }
    }
}
