using System;

namespace task2._2105
{
    /// <summary>
    ///  This class contains method to calculate square of rectangle
    /// </summary>
    public class SquareCalculator
    {
        int Length { get; set; }
        int Weight { get; set; }

        public SquareCalculator(int pLength, int pWeight)
        {
            Length = pLength;
            Weight = pWeight;
        }

        /// <summary>
        ///  This method calculate square of rectangle
        /// </summary>
        public int GetSquare()
        {
            if ((Length < 0) || (Weight < 0))
            {
                throw new ArgumentException("Error! Arguments is negative number.");
            }
            if ((Length == 0) || (Weight == 0))
            {
                throw new ArgumentNullException("Error! Rectangle can't have a null side.");
            }
            return Length * Weight;
        }
    }
}
