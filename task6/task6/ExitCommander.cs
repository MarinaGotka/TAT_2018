using System;

namespace task_DEV6
{
    /// <summary>
    /// Class implements command interface and allows to end the program through method.
    /// </summary>
    class ExitCommander : ICommand
    {
        Receiver receiver;

        public ExitCommander(Receiver r)
        {
            receiver = r;
        }

        /// <summary>
        /// Implemented method allows to end the program.
        /// </summary>
        public void Execute()
        {
            receiver.Exit();
        }
    }
}
