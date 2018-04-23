using System.Collections.Generic;


namespace task_7
{
    class FindCarsFromCatalog : ICommand
    {
        Receiver receiver;
        public FindCarsFromCatalog(Receiver rec)
        {
            receiver = rec;
        }

        public IEnumerable<Car> Execute(Car car,string path)
        {
            return receiver.FindCarsFromCatalog(car,path);
        }
    }
}
