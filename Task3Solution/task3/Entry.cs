using System;
using System.Numerics;

namespace task_DEV3
{
    class Entry
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2)
                {
                    throw new Exception("Error. Invalid number of parameters entered or no parameters entered. ");
                }
                BigInteger number = BigInteger.Parse(args[0]);
                int radix = int.Parse(args[1]);

                ConverterToAnotherNumeralSystem numberResults = new ConverterToAnotherNumeralSystem(number, radix);
                numberResults.ConvertToAnotherNumeralSystem();
                numberResults.PrintNumberInNewNumeralSystem();     
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
