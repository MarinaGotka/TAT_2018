using System.Collections.Generic;

namespace task_7
{
    /// <summary>
    /// Interface to inheriting and implementing method for creating car
    /// </summary>
    public interface ICommand 
    {
        IEnumerable<Car> Execute(Car car);
    }
}
