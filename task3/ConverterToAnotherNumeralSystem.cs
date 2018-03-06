using System;
using System.Text;

namespace task_DEV3
{
    /// <summary>
    ///  This class for converting number from decimal to another numeral system from 2 to 20
    /// </summary>
    class ConverterToAnotherNumeralSystem
    {
        ulong decNumber;
        byte radixResult;
        StringBuilder numberResult;

        public ConverterToAnotherNumeralSystem(ulong number, byte radix)
        {
            decNumber = number;
            radixResult = radix;
            numberResult = new StringBuilder();
        }

        /// <summary>
        /// Method converts decimal number to another numeral system from 2 to 20
        /// </summary>
        public void ConvertToAnotherNumeralSystem()
        {
            ulong decNumberTemp = decNumber;
            while (decNumberTemp > 0)
            {
                byte remain = (byte)(decNumberTemp % radixResult);
                if (remain < 10)
                {
                    numberResult.Insert(0, remain);
                }
                else
                {
                    char remainSymbol = (char)('A' + remain - 10);
                    numberResult.Insert(0, remainSymbol);
                }
                decNumberTemp /= radixResult;
            }
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