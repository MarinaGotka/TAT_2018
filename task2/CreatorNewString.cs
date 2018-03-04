using System;
using System.Text;

namespace task_DEV2
{
    /// <summary>
    ///  This class contains the method for create a new string with only even indexes
    /// </summary>
    class CreatorStringOnlyOfEvenIndexes
    {
        public string str;
        public CreatorStringOnlyOfEvenIndexes(string str0)
        {
            str = str0;
        }

        /// <summary>
        /// Method for create a new string with only even indexes
        /// </summary>
        /// <param name="str">string for processing</param>
        /// <returns> String contains with only even indexes </returns>
        public string BuildSubstringOnlyOfEvenIndexes() 
         {
            StringBuilder resultStr = new StringBuilder();
            for (int i = 0; i < str.Length; i += 2)
            {
                resultStr.Append(str[i]);
            }
            return resultStr.ToString();
        }
    }
}
