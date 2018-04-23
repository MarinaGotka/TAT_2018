using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    /// <summary>
    ///  This strust contains information about users and methods for operations with users
    /// </summary>
    public struct User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }


        public User(string firstName, string lastName, string gender, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
        }


        /// <summary>
        ///  This method for calculate average age of users
        /// </summary>
        /// <returns>
        ///  The average age
        /// </returns>
        public float CalculateAverageAge(List<User> users)
        {
            float averageAge = 0;
            int sumAge = 0;
            foreach (User u in users)
            {
                if (u.Age < 0 || u.Age > 100)
                {
                    throw new FormatException("Error!Wrong format of Age.");
                }
                sumAge += u.Age;
            }
            averageAge = (float) sumAge / users.Count;

            return averageAge;
        }

        /// <summary>
        ///  This method for finding the most eldest user
        /// </summary>
        /// <returns>
        ///  List of the most oldest users
        /// </returns>
        public List<User> FindEldestUser(List<User> users)
        {
            int maxAge = users[0].Age;
            foreach (User u in users)
            {
                if(u.Age > maxAge)
                {
                    maxAge = u.Age;
                }
            }
          List<User> eldestUsers = new List<User> (users.Where(u => (u.Age == maxAge)));
          return eldestUsers;
        }

        /// <summary>
        ///  This method for find females popular name
        /// </summary>
        /// <returns>
        ///  List of the most popular females names
        /// </returns>
        public List<string> FindFemalesPopulaName(List<User> users)
        {
            List<string> popularNames = new List<string>() ;
            string popularName = null;
            int[] namesCount = new int[users.Count];

            for(int i = 0; i < users.Count; i++)
            {
                if (users[i].Gender == "f")
                {
                    popularName = users[i].FirstName;
                    for (int j = i + 1; j < users.Count; j++)
                    {
                        if (users[i].FirstName == users[j].FirstName)
                        {
                            namesCount[i] += 1;
                        }
                    }
                }
            }
            int max = 0;
            for(int m = 0; m < namesCount.Length; m++)
            {
                if(namesCount[m] > max)
                {
                    max = namesCount[m];
                }
            }
            for (int n = 0; n < namesCount.Length; n ++)
            {
                if (namesCount[n] == max)
                {
                    popularNames.Add(users[n].FirstName);
                }
            }
            return popularNames;
        }

        /// <summary>
        ///  This overriding method for presenting user as a string
        /// </summary>
        /// <returns>
        ///  User as a string
        /// </returns>
        public override string ToString()
        {
            string line = "First name: " + FirstName + " Last name: " + LastName + " Gender: " + Gender + " Age: " + Age;
            return line;
        }
    }
}
