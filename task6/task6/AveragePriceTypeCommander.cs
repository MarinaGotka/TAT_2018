using System;

namespace task_DEV6
{
    /// <summary>
    /// Class implements command interface and calculates average price all goods of choosen type through method.
    /// </summary>
    public class AveragePriceTypeCommander : ICommand
    {
        Receiver receiver;

        public AveragePriceTypeCommander(Receiver r)
        {
            receiver = r;
        }

        /// <summary>
        /// Implemented method average price all goods of choosen type.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("Input type for command: ");
            string type = Console.ReadLine();
            Console.Write("Average price of goods {0} types : ", type);
            Console.WriteLine(receiver.GetAveragePrice(type));
        }
    }
}
