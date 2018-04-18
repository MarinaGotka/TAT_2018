using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    /// <summary>
    ///  This class contains methods for inputting information about users and for operations with users
    /// </summary>
    public class Inputor
    {
        string firstName;
        string lastName;
        string gender;
        int age;
        List<User> users = new List<User>();
        List<ICommand> commands = new List<ICommand>()
        {
            new AverageAgeCommander(),
            new EldestUserCommander(),
            new PopularFemaleNameCommander()
        };
        
        public Inputor()
        {
        }

        /// <summary>
        ///  This method is menu for inputting data
        /// </summary>
        public void InputData()
        {
            Namesake += NamesakeUsers;
            while (true)
            {
                Console.WriteLine("Input first name: ");
                firstName = Console.ReadLine();

                Console.WriteLine("Input last name: ");
                lastName = Console.ReadLine();

                InputGender();
                InputAge();
                User user = new User(firstName, lastName, gender, age);
                FindNamesake(lastName);
                users.Add(user);
     
                Console.WriteLine("Input '1' to add user or '2' to exit inputting: ");
                if (Console.ReadLine() == "2")
                {
                    foreach(ICommand c in commands)
                    {
                        c.Execute(users);
                    }
                    break;
                }
            }
        }

        /// <summary>
        ///  This method for find namesake in users list
        /// </summary>
        public void FindNamesake(string lastName)
        {
            NamesakeEventArgs args = new NamesakeEventArgs();
            args.LastName = lastName;
            foreach (User u in users)
            {
                if (lastName == u.LastName)
                {
                    OnNamesake(args);
                    break;
                }
            }
        }

        /// <summary>
        ///  This method to input age of user
        /// </summary>
        public void InputAge()
        {
            int inputtingAge = 0;
            do
            {
                Console.WriteLine("Input age: ");
                if (!Int32.TryParse(Console.ReadLine(), out inputtingAge))
                {
                    Console.WriteLine("Error!Wrong format of age. Repeat inputting,please.");
                    inputtingAge = 0;
                }
                if (inputtingAge < 0 || inputtingAge > 100)
                {
                    Console.WriteLine("Error!Wrong format of age. Repeat inputting,please.");
                    inputtingAge = 0;
                }
                age = inputtingAge;
            } while (inputtingAge == 0);
        }

        /// <summary>
        ///  This method to input gender of user
        /// </summary>
        public void InputGender()
        {
            do
            {
                Console.WriteLine("For choosing gender input (male - 'm', female - 'f', not specified - 'n'): ");
                gender = Console.ReadLine();
                switch (gender)
                {
                    case "m":
                        gender = "male";
                        break;
                    case "f":
                        gender = "female";
                        break;
                    case "n":
                        gender = "not specified";
                        break;
                    default:
                        gender = null;
                        Console.WriteLine("Incorrect data. Repeate choosing");
                        break;

                }
            } while (gender == null);
        }

        /// <summary>
        ///  This method to display all users
        /// </summary>
        public void Display()
        {
            foreach (User u in users)
            {
                Console.WriteLine(u);
            }
        }

        public event EventHandler<NamesakeEventArgs> Namesake;

        /// <summary>
        ///  This method for using EventHandler
        /// </summary>
        protected virtual void OnNamesake(NamesakeEventArgs e)
        {
            EventHandler<NamesakeEventArgs> handler = Namesake;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        /// <summary>
        ///  This method for using EventHandler
        /// </summary>
        public void NamesakeUsers(object sender, NamesakeEventArgs e)
        {
            Console.WriteLine("Namesake: ");
            List<User> namesakeUsers = new List<User>(users.Where(u => (u.LastName == e.LastName)));
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Марина\Desktop\TAT_2018\task8\task8\file.txt"))
            {
                foreach (User u in namesakeUsers)
                {
                    Console.WriteLine(u + "\n");
                    file.Write(u);
                }
               
            }
        }
    }
}
