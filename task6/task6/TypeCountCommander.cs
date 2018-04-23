using System;

namespace task_DEV6
{
    /// <summary>
    /// Class implements command interface and calculates count of goods types.
    /// </summary>
    public class TypeCountCommander : ICommand
    {
        Receiver receiver;

        public TypeCountCommander(Receiver r)
        {
            receiver = r;
        }

        /// <summary>
        ///Implemented method calculates count of goods types.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine(receiver.GetCountTypes());
        }

    }
}
