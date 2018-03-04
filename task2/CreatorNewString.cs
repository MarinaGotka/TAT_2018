using System;
using System.Text;

namespace task_DEV2
{
    /// <summary>
    ///  This class contains the method for create a new string with only even indexes
    /// </summary>
    class CreatorStringOnlyOfEvenIndexes
    {
        public string initialStr;
        public CreatorStringOnlyOfEvenIndexes(string str)
        {
            initialStr = str;
        }

        /// <summary>
        /// Method for create a new string with only even indexes
        /// </summary>
        /// <param name="str">string for processing</param>
        /// <returns> String contains with only even indexes </returns>
        public string BuildSubstringOnlyOfEvenIndexes() 
         {
            StringBuilder resultStr = new StringBuilder();
            for (int i = 0; i < initialStr.Length; i += 2)
            {
                resultStr.Append(initialStr[i]);
            }
            return resultStr.ToString();
        }
    }
}
