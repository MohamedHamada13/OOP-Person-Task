using System;

namespace OOP_EX_1__Person_task_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("mohamed", 21, true));
            people.Add(new Person("ahmed", 29, true));
            people.Add(new Person("aya", 26, false));

            foreach (var person in people)
            {
                person.PrintInfo();
                Console.WriteLine();
            }
        }
    }

    internal class Person
    {
        // Fields
        public string name;
        public int age;
        public bool gender;

        // Parameterized Constractor
        public Person(string Name, int Age, bool Gender)
        {
            this.name = Name;
            this.age = Age;
            this.gender = Gender;
        }

        // Methods
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            switch (gender)
            {
                case bool genderTmp when (genderTmp == true):
                    Console.WriteLine($"Gender: Man");
                    break;
                case bool genderTmp when (genderTmp == false):
                    Console.WriteLine($"Gender: Woman");
                    break;
            }
        }
    }
}