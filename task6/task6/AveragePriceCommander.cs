using System;

namespace task_DEV6
{

    /// <summary>
    /// Class implements command interface and calculates average price all goods in the list through method.
    /// </summary>
    class AveragePriceCommander : ICommand
    {
        Receiver receiver;

        public AveragePriceCommander(Receiver r)
        {
            receiver = r;
        }

        /// <summary>
        /// Implemented method average price all goods in the list
        /// </summary>
        public void Execute()
        {
           Console.WriteLine( receiver.GetAveragePrice());
        }
    }
}
