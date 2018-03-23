using System;

namespace task_DEV6
{
    /// <summary>
    /// Class implements command interface and calculates count of all goods through method.
    /// </summary>
    public class CountAllCommander : ICommand
    {
        Receiver receiver;

        public CountAllCommander(Receiver r)
        {
            receiver = r;
        }

        /// <summary>
        /// Implemented method calculates count of all goods.
        /// </summary>
        public void Execute()
        {
          Console.WriteLine(receiver.GetCountAll());
        }
    }
}
