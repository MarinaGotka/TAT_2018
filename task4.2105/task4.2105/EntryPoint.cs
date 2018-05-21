using System;

namespace task4._2105
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                InputPerson();
                Person person = new Person();
                person.PrintPerson();
                Console.WriteLine("Younger person: " + person.GetYoungerPerson().ToString());
                Console.WriteLine("Elder person: " + person.GetElderPerson().ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        ///  This method to inputting new person
        /// </summary>
        public static void InputPerson()
        {
            while (true)
            {
                Console.WriteLine("Input First Name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Input LastName:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Input First Name:");
                int age = Int32.Parse(Console.ReadLine());

                Person person = new Person(firstName, lastName, age);
                person.AddPerson(person);

                Console.WriteLine("For continue inputting press 1, to exit press 2");
                int number = Int32.Parse(Console.ReadLine());

                if(number == 2)
                {
                    break;
                }
            }
        }
    }
}
