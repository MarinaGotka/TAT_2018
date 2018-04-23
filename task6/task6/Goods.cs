using System;
using System.Linq;

namespace task_DEV6
{
    /// <summary>
    /// Class creates an object Goods type.
    /// </summary>
    public class Goods
    {
        string type;
        string name;
        int count;
        float cost;

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        public float Cost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }

        public Goods(string typeG, string nameG, int countG, float costG)
        {
            if (countG <= 0 || costG <= 0)
            {
                throw new ArgumentException("Invalid arguments format. Numbers can't be negative or equal to zero");
            }
            if (typeG == String.Empty || nameG == String.Empty)
            {
                throw new ArgumentNullException("String is empty.");
            }
            if ((costG.ToString().Contains(',')) && (costG.ToString().Contains('.')))
            {
                throw new FormatException("Wrong format of cost.");
            }
            type = typeG;
            name = nameG;
            count = countG;
            cost = costG;
        }
    }
}
