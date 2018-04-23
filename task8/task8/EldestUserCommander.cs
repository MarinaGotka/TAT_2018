using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    public class EldestUserCommander : ICommand
    {
        User user;
        public void Execute(List<User> users)
        {
            List<User> elderUsers = user.FindEldestUser(users);
            Console.WriteLine("The eldest users: ");
            foreach (User u in elderUsers)
            {
                Console.WriteLine(u + "\n");
            }
        }
    }
}
