using System;
using System.Collections.Generic;

namespace task_DEV6
{
    /// <summary>
    /// Class receives and executes commands through methods.
    /// </summary>
    public class Receiver
    {
        List<Goods> goods;

        public Receiver()
        {
            goods = new List<Goods>();
        }

        /// <summary>
        /// Method to add new goods in the list.
        /// </summary>
        public List<Goods> AddGoods(Goods goodsG)
        {
            if (goodsG == null)
            {
                throw new InvalidOperationException("Goods is not found.");
            }
            goods.Add(goodsG);
            return goods;
        }

        /// <summary>
        /// Method caclulate count of goods types.
        /// </summary>
        public int GetCountTypes()
        {
            int countTypes = 0;
            foreach (Goods i in goods)
            {
                countTypes++;
            }
            return countTypes;
        }

        /// <summary>
        /// Method caclulate count of all goods.
        /// </summary>
        public int GetCountAll()
        {
            int countAll = 0;
            foreach (Goods i in goods)
            {
                countAll += i.Count;
            }
            return countAll;
        }

        /// <summary>
        /// Method caclulate average price of all goods.
        /// </summary>
        public float GetAveragePrice()
        {
            float averagePrice = 0;
            float sumPrice = 0;
            foreach (Goods i in goods)
            {
                sumPrice += i.Cost * i.Count;
            }
            averagePrice = sumPrice / GetCountAll();
            return averagePrice;
        }

        /// <summary>
        /// Method caclulate average price of goods of a choosen type.
        /// </summary>
        public float GetAveragePrice(string type)
        {
            if (goods == null)
            {
                throw new InvalidOperationException("Error.No any goods.");
            }
            if (type == String.Empty)
            {
                throw new ArgumentNullException("Error.Type is not found.");
            }
            float averagePrice = 0;
            float sumPrice = 0;
            int count = 0;
            foreach (Goods i in goods)
            {
                if (i.Type == type)
                {
                    sumPrice += i.Cost * i.Count;
                    count += i.Count;
                }
            }
            averagePrice = sumPrice / count;
            return averagePrice;
        }

        /// <summary>
        /// Method to exit the program.
        /// </summary>
        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
