using System;
using System.Numerics;

namespace task_DEV3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Error. Invalid number of parameters entered or no parameters entered. ");
            }
            else if (int.Parse(args[1]) >= 2 || int.Parse(args[1]) <= 20)
            {
                ConverterToAnotherNumeralSystem numberResults = new ConverterToAnotherNumeralSystem(BigInteger.Parse(args[0]), int.Parse(args[1]));
                numberResults.ConvertToAnotherNumeralSystem();
                numberResults.PrintNumberInNewNumeralSystem();
            }
            else
            {
                Console.WriteLine("Error. Data can not be converted. Incorrect data format.");
            }
        }
    }
}
