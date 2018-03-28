using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_7;

namespace task_DEV7.Commands
{
    class FindCarsFromCatalog : ICommand
    {
        Receiver receiver;
        public FindCarsFromCatalog(Receiver rec)
        {
            receiver = rec;
        }

        public IEnumerable<Car> Execute(Car car)
        {
            return receiver.FindCarsFromCatalog(car);
        }
    }
}
