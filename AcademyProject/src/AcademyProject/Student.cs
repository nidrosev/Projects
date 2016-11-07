using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyProject
{
    class Student : Person
    {
        public string StudentName { get; set; }
        public static int studentAutoIncriment = 0;
        public int studentId { get; set; }
        public int courseId = 0;
        public Course course { get; set; }

        public Student(string name, byte age) : base(name, age)
        {
            studentAutoIncriment++;
            this.studentId = studentAutoIncriment;

        }
        public void AddCourse()
        {
            this.course = course;
        }

        public override string ToString()
        {
            return name;
        }




    }
}