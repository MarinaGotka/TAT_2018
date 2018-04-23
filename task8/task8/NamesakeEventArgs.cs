using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{

    /// <summary>
    ///  This class for using EventHandler for find namesake
    /// </summary>
    public class NamesakeEventArgs : EventArgs
    {
        public string LastName { get; set; }
    }
}
