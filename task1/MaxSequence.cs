using System;

namespace task_DEV1
{
    /// <summary>
    ///  This class contains the method for counting the maximum number of identical consecutive elements in a string
    /// </summary>
    class MaxSequence
    {
        public string str;
        public MaxSequence(string maxSequence)
        {
            str = maxSequence;
        }

        /// <summary>
        /// Method for counting the maximum number of identical consecutive elements in a string
        /// </summary>
        /// <param name="str">string for processing</param>
        /// <returns> The maximum number of identical consecutive elements in a string </returns>
        public int CalculateMaxNumberOfRepetitions()
        {
            int maxCount = 0;
            int currentCount = 1;
            for (int i = 0; (i <= str.Length - maxCount && i + 1 < str.Length); i++)
            {
                if (str[i] == str[i + 1])
                {
                    currentCount++;
                }
                else if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    currentCount = 1;
                }
                else
                {
                    currentCount = 1;
                }
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }
            return maxCount;
        }
    }
}
