using System;

namespace task_DEV6
{

    /// <summary>
    /// Class implements command interface and adds new goods in the list of goods through method.
    /// </summary>
    class AddGoodsCommander : ICommand
    {
        Receiver receiver;

        public AddGoodsCommander(Receiver r)
        {
            receiver = r;
        }

        /// <summary>
        /// Implemented method to add new goods in the list of goods
        /// </summary>
        public void Execute (Goods goods)
        {
            receiver.AddGoods(goods);
        }

        public void Execute()
        {
        }
    }
}
