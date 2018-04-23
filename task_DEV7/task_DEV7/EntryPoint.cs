using System;

namespace task_7
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Receiver receiver = new Receiver();
                Invoker invoker = new Invoker(receiver);
                invoker.Menu();

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
