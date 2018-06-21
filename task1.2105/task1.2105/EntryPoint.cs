using System;
using System.Text;

namespace task1._2105
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            StringBuilder charString = new StringBuilder();
            Random random = new Random();
            int charsCount = random.Next(5, 50);

            for(int i = 0; i < charsCount; i++)
            {
                charString.Append("!");
            }

            Console.WriteLine("Hello, world!\nAnd hi again!\n"+charString);
        }
    }
}
