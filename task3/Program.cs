﻿using System;

namespace task_DEV3
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number;
            byte radix;

            if (args.Length == 0)
            {
                Console.WriteLine("Error. No parameters intered.");
            }
            else if (!ulong.TryParse(args[0], out number) || (!byte.TryParse(args[1], out radix)))
            {
                Console.WriteLine("Error. Incorrect data format.");
            }
            else if (radix >= 2 && radix <= 20)
            {
                ConverterToAnotherNumeralSystem numberResults = new ConverterToAnotherNumeralSystem(number, radix);
                numberResults.ConvertToAnotherNumeralSystem();
                numberResults.PrintNumberInNewNumeralSystem();
            }
            else
            {
                Console.WriteLine("Error. Data can not be converted. ");
            }
        }
    }
}
