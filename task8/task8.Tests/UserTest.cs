using System;
using System.Collections.Generic;
using Xunit;

namespace task8.Tests
{
    public class UserTest
    {
        List<User> users = new List<User>()
        {
            new User("Maria","Pupkina","f",23),
            new User("Victor","Averin","m",15),
            new User("Zhanna","Kuzmina","f",32),
            new User("Anastasia","Pupkina","f",19)

        };

        [Fact]
        public void CalculateAverageAgePositiveTest()
        {
        User user = new User("Anastasia", "Pupkina", "f", 19);
        float expected = 22.25f;

        float result = user.CalculateAverageAge(users);

        Assert.Equal(expected, result);

        }
        
        [Fact]
        public void CalculateAverageAgeWrongData()
        {
            User user = new User("Anastasia", "Plotnikova", "f", -19);
            users.Add(user);

            Assert.Throws<FormatException>(() => user.CalculateAverageAge(users));

        }

        [Fact]
        public void FindEldestUserPositiveTest()
        {
            User user = new User("Anastasia", "Pupkina", "f", 19);
            List<User> expectedList = new List<User>()
            {
                 new User("Zhanna","Kuzmina","f",32)
            };

            List<User> resultList = user.FindEldestUser(users);

            Assert.Equal(expectedList, resultList);
        }

        [Fact]
        public void FindEldestUserSeveralEldestUsers()
        {
            User user = new User("Anastasia", "Vasileva", "f", 17);
            users.Add(user);
            List<User> expectedList = new List<User>()
            {
                new User("Anastasia", "Vasileva", "f", 17),
                new User("Anastasia", "Pupkina", "f", 32)
            };

            List<User> resultList = user.FindEldestUser(users);
            
            Assert.Equal(expectedList, resultList);

        }

        [Fact]
        public void FindFemalesPopulaNameTest()
        {
            User user = new User("Maria", "Luna", "f", 24);

            users.Add(user);
            List<string> expectedList = new List<string>()
            {
                 "Maria"
            };

            List<string> resultList = user.FindFemalesPopulaName(users);

            Assert.Equal(expectedList, resultList);
        }

        [Fact]
        public void FindFemalesPopulaNameTestSeveralNames()
        {
            User userM = new User("Maria", "Luna", "f", 24);
            User user = new User("Viktoria", "One", "f", 18);
            User userV = new User("Viktoria", "Two", "f", 23);
            users.Add(user);
            users.Add(userV);
            users.Add(userM);
            List<string> expectedList = new List<string>()
            {
                 "Maria",
                 "Viktoria"
            };

            List<string> resultList = user.FindFemalesPopulaName(users);

            Assert.Equal(expectedList, resultList);
        }
    }
}
