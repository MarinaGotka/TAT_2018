using System;

namespace task_DEV1
{
    class Entry
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                MaxSequence maxSequense = new MaxSequence(args[0]);
                int maxCount = maxSequense.CalculateMaxNumberOfRepetitions();
                Console.WriteLine("Maximum = {0}", maxCount);
            }
            else
            {
                Console.WriteLine("Error.The string is not single or empty");
            }
        }

    }
}
