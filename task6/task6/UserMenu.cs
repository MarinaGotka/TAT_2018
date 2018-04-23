using System;

namespace task_DEV6
{
    /// <summary>
    /// Class for displaying the menu of command and communicating with the user.
    /// </summary>
    public class UserMenu
    {
        Receiver receiver;
        public UserMenu(Receiver rec)
        {
            this.receiver = rec;
        }

        /// <summary>
        ///The method works depending on what the user chooses.
        /// </summary>
        public void Menu()
        {
            while (true)
            { 
            Console.WriteLine("Select: \n 1.Add goods\n " +
                "2.Count types\n " +
                "3.Count all\n " +
                "4.Average price\n " +
                "5.Average price(separate type)\n " +
                "6.Exit\n");
            int input;
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                    throw new FormatException("Error.Invalid data.");
            }
                switch (input)
                {
                    case 1:
                        InputGoods();
                        break;
                    case 2:
                        TypeCountCommander commandT = new TypeCountCommander(receiver);
                        Console.Write("Count types of goods :");
                        commandT.Execute();
                        Console.WriteLine();
                        break;
                    case 3:
                        CountAllCommander commandA = new CountAllCommander(receiver);
                        Console.Write("Count all goods : ");
                        commandA.Execute();
                        Console.WriteLine();
                        break;
                    case 4:
                        AveragePriceCommander commandAP = new AveragePriceCommander(receiver);
                        Console.Write("Average price of all goods : ");
                        commandAP.Execute();
                        Console.WriteLine();
                        break;
                    case 5:
                        AveragePriceTypeCommander commandAPT = new AveragePriceTypeCommander(receiver);
                        commandAPT.Execute();
                        Console.WriteLine();
                        break;
                    case 6:
                        ExitCommander commandE = new ExitCommander(receiver);
                        commandE.Execute();
                        break;
                    default:
                        Console.WriteLine("Wrong number of command.");
                        break;
                } 
            }
        }

        /// <summary>
        ///method performs a dialog with the user and saves the inputting information.
        /// </summary>
        public void InputGoods()
        {
            char specialChar = 's';
            while(true)
            {
                Console.Write("Input type of goods: ");
                string type = Console.ReadLine();
                while (type == String.Empty)
                {
                   Console.WriteLine("Type is empty. Please, repeate inputting.");
                   type = Console.ReadLine();
                }
                Console.Write("Input name of goods: ");
                string name = Console.ReadLine();
                while (name== String.Empty)
                {
                Console.WriteLine("Name is empty. Please, repeate inputting.");
                name = Console.ReadLine();
                }
                int count;
                Console.Write("Input count of goods: ");
                while (!int.TryParse(Console.ReadLine(), out count))
                {
                    Console.WriteLine("Invalid data format.");
                    count = int.Parse(Console.ReadLine());
                }
                float cost;
                Console.Write("Input cost of goods: ");
                while (!float.TryParse(Console.ReadLine(), out cost))
                {
                    Console.WriteLine("Invalid data format.");
                    cost = float.Parse(Console.ReadLine());
                }
                AddGoodsCommander commandAdd = new AddGoodsCommander(receiver);
                commandAdd.Execute(new Goods (type,name,count,cost));
                Console.WriteLine("To stop entering goods input : " + specialChar + ". To continue click another button...");
                char stop = char.Parse(Console.ReadLine());
                if (stop == specialChar)
                {
                    Menu();
                }
            }            
        }
    }
}
