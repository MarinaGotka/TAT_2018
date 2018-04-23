using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    public class AverageAgeCommander : ICommand
    {
        User user;
        public void Execute(List<User> users)
        {
            Console.WriteLine("Average age: ");
            Console.WriteLine(user.CalculateAverageAge(users) + "\n");
        }
    }
}
