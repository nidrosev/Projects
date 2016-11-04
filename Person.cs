using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Person
    {
        public string name;
        public byte age;

        private static int mCurrentGlobalId;

        public int Id { get; set; }

        public Person()
        {
            Id = mCurrentGlobalId++;
            this.name = "No name";
            this.age = 1;

            // Console.WriteLine("Name : {0} , Age : {1}", this.name, this.age);

        }
        public Person(string name) : this()
        {
            this.name = name;
            // Console.WriteLine("Name i : {0} ,Age is {1}", this.name, this.age);

        }
        public Person(string name, byte age) : this(name)
        {
            this.age = age;
            //Console.WriteLine("Name i : {0}, Age is {1}", this.name, this.age);

        }

        public void  EnterData()
        {
            string PersonString = "";
            List<string> personData = new List<string>();
            var people = new List<Person>();
            do
            {
                Console.WriteLine("Enter Person data:");
                PersonString = Console.ReadLine();
                if (PersonString != "quit")
                {
                    people.Add(this.ParseData(PersonString));
                }

            } while (PersonString != "quit");

            this.PeopleSort(people);
            

        }

        public Person ParseData(string PersonString)
        {
            
                string[] person = PersonString.Split(new string[] { "//" }, StringSplitOptions.RemoveEmptyEntries);
                var p = new Person(person[0], byte.Parse(person[1]));
            
            return p;
           
        }

        public void PeopleSort(List<Person> peopleResult)
        {

            peopleResult = peopleResult.Where(x => x.age > 18).OrderByDescending(x => x.name.Length).ToList<Person>();
            foreach (var item in peopleResult)
            {
                Console.WriteLine("Name is {0} , Age is {1}", item.name, item.age);
            }

            Console.ReadKey();
        }
    }
}
