using System;

namespace task2._2105
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                int length = Int32.Parse(args[0]);
                int weight = Int32.Parse(args[1]);

                SquareCalculator squareCalculator = new SquareCalculator(length, weight);
                squareCalculator.GetSquare();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
