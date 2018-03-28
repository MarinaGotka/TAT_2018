using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_7;

namespace task_DEV7.Commands
{
    class FindCarsFromStorage : ICommand
    {
        Receiver receiver;
        public FindCarsFromStorage(Receiver rec)
        {
            receiver = rec;
        }

        public IEnumerable<Car> Execute(Car car)
        {
            return receiver.FindCarsFromStorage(car);
        }
    }
}
