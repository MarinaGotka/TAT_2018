using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Inputor inputUser = new Inputor();
                inputUser.InputData();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
