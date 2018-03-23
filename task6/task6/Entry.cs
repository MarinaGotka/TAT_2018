using System;
using System.Globalization;
using System.Threading;

namespace task_DEV6
{
    class Entry
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            try
            {
                Receiver receiver = new Receiver();
                UserMenu menu = new UserMenu(receiver);
                menu.Menu();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

