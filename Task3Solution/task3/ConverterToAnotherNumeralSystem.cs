using System;
using System.Text;
using System.Numerics;

namespace task_DEV3
{
    /// <summary>
    ///  This class for converting number from decimal to another numeral system from 2 to 20
    /// </summary>
   public class ConverterToAnotherNumeralSystem
    {
        BigInteger decNumber;
        int radixResult;
        StringBuilder numberResult = new StringBuilder();

        public ConverterToAnotherNumeralSystem(BigInteger number,int radix)
        {
            decNumber = number;
            radixResult = radix;
        }

        /// <summary>
        /// Method converts decimal number to another numeral system from 2 to 20
        /// </summary>
        public string ConvertToAnotherNumeralSystem()
        {
            if (radixResult < 2 || radixResult > 20)
            {
                throw new FormatException("Error. Data can not be converted. Incorrect data format.");
            }
            if (decNumber < 0)
            {
                throw new ArgumentException("Error. Data can not be converted. Arguments must be positive.");
            }

            while (decNumber != 0)
            {
                int remain = (int)(decNumber % radixResult);
                if (remain < 10)
                {
                    numberResult.Insert(0, remain);
                }
                else
                {
                    char remainSymbol = (char)('A' + remain - 10);
                    numberResult.Insert(0, remainSymbol);
                }
                decNumber /= radixResult;
            }
            return numberResult.ToString();
        }

        /// <summary>
        /// Prints the number in the new numeral system
        /// </summary>            
        public void PrintNumberInNewNumeralSystem()
        { 
            Console.WriteLine($"Number in the new numeral system {radixResult} : {numberResult}");
        }
    }
}