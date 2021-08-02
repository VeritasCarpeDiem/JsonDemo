using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("person.json"); //remember to copy always

            Person person = JsonSerializer.Deserialize<Person>(text);

            List<Person> people = new List<Person>() { person, person, person };

            Console.WriteLine(JsonSerializer.Serialize(people));

            Console.WriteLine(person.ToString());

        }
    }


    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }

        public Person() { }

        public Person(string name, int age, char gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"Person: Name:{Name}, Age:{Age}, Gender:{Gender}";
        }
    }
}
