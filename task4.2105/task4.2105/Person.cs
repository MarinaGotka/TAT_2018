using System;
using System.Collections.Generic;

namespace task4._2105
{

    /// <summary>
    ///  This class to create Person. Contains methods to operating with persons.
    /// </summary>
    public class Person
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        List<Person> people = new List<Person>();

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            if((age <= 0)||(age > 100))
            {
                throw new ArgumentException("Error! Wronf age format.");
            }
            Age = age;
        }

        public Person()
        {
        }

        /// <summary>
        ///  This method to add new person to the list of person
        /// </summary>
        public void AddPerson(Person person)
        {
            people.Add(person);
        }


        /// <summary>
        ///  This method to print list of person
        /// </summary>
        public void PrintPerson()
        {
            foreach(Person person in people)
            {
                Console.WriteLine(person);
            }
        }

        /// <summary>
        ///  This method to find youngest person
        /// </summary>
        public Person GetYoungerPerson()
        {
            int minAge = people[0].Age;
            Person youngerPerson = people[0];

            foreach (Person person in people)
            {
                if(person.Age < minAge)
                {
                    minAge = person.Age;
                    youngerPerson = person;
                }
            }
            return youngerPerson;
        }

        /// <summary>
        ///  This method to find eldest person
        /// </summary>
        public Person GetElderPerson()
        {
            int maxAge = people[0].Age;
            Person elderPerson = people[0];

            foreach (Person person in people)
            {
                if (person.Age > maxAge)
                {
                    maxAge = person.Age;
                    elderPerson = person;
                }
            }
            return elderPerson;
        }

        public override string ToString()
        {
            string line = " First Name: " + FirstName + " LastName: " + LastName + " Age: "
                    + Age;
            return line;
        }
    }
}
