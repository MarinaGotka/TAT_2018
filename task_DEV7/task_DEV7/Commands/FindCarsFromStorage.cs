using System.Collections.Generic;

namespace task_7
{
    class FindCarsFromStorage : ICommand
    {
        Receiver receiver;
        public FindCarsFromStorage(Receiver rec)
        {
            receiver = rec;
        }

        public IEnumerable<Car> Execute(Car car,string path)
        {
            return receiver.FindCarsFromStorage(car,path);
        }
    }
}
