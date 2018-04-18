using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    public class PopularFemaleNameCommander : ICommand
    {
        User user;
        public void Execute(List<User> users)
        {
            Console.WriteLine("The most popular name: ");
            List<string> popularNames = user.FindFemalesPopulaName(users);
            foreach (string u in popularNames)
            {
                Console.WriteLine(u + "\n");
            }
        }
    }
}
