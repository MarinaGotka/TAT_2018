using System;
using System.Text;

namespace task_DEV2
{
    /// <summary>
    ///  This class contains the method for create a new string with only even indexes
    /// </summary>
    public class EvenIndexesStringCreator
    {
        public string initialString;
        public EvenIndexesStringCreator(string str)
        {
            initialString = str;
        }

        /// <summary>
        /// Method for create a new string with only even indexes
        /// </summary>
        /// <returns> String contains with only even indexes </returns>
        public string BuildSubstringOnlyOfEvenIndexes()
        {
            if (String.IsNullOrEmpty(initialString))
            {
                throw new Exception ("String is empty");
            }
            StringBuilder resultString = new StringBuilder();
            for (int i = 0; i < initialString.Length; i += 2)
            {
                resultString.Append(initialString[i]);
            }
            return resultString.ToString();
        }
    }
}
