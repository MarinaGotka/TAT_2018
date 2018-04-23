using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    /// <summary>
    /// Interface to inheriting and implementing method for operation with users
    /// </summary>
    public interface ICommand
    {
        void Execute(List<User> users);
    }
}
