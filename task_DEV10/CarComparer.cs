using System.Collections.Generic;

namespace task_DEV10
{
    class CarComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x.CountCars == 0)
            {
                if (y.CountCars == 0)
                { 
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                if (y.CountCars == 0)
                {
                    return -1;
                }
                else
                {
                    int retval = x.CountCars.CompareTo(y.CountCars);

                    if (retval != 0)
                    {
                        return -retval;
                    }
                    else
                    {
                        return x.CountCars.CompareTo(y.CountCars);
                    }
                }
            }
        }
    }
}
