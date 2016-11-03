using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Student:Person
    {
        public string StudentName{get;set;}
        public List<Student> studentList;

     public Student()
     {
            this.CheckStudent();
            base.EnterData();
        }

      public void CheckStudent()
        {
            Console.WriteLine("Enter a student name:");
            string StudentName = Console.ReadLine();
           // var studentList = new List<Person>();
            var studentList = base.peopleResultn;
            foreach (var item in studentList) {
             if (item.name == StudentName)
                {
                    Console.WriteLine("{0} - This student already exists");
                }
            }
        }
        public void AddStudent ()
        {
            Console.WriteLine("Enter a student name:");
            var studentList = base.peopleResultn;
        }
        
    }
}
