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
            
     }

      public void CheckStudent()
        {
            Console.WriteLine("Enter a student name:");
            string StudentName = Console.ReadLine();
           // var studentList = new List<Person>();
           

            bool exists = base.peopleResultn.Exists(x => x.name == StudentName);
            if (exists) {
                Console.WriteLine("Student with name {0} already exist", StudentName); 
                    } else {
                Console.WriteLine("Student with name {0} do not exist", StudentName);
            }
        }
        public void AddStudent ()
        {
            Console.WriteLine("Enter a student name:");
            var studentList = base.peopleResultn;
        }
        
    }
}
