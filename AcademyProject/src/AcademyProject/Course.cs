using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyProject
{
    class Course : Person
    {
        public string Name { get; set; }
        public int StudentsCount { get; set; }
        public int Capacity { get; set; }
        public int Duaration { get; set; }
        public static int CourseAutoIncriment = 0;
        public int courseId { get; set; }
        List<Student> ListCourseStudent = new List<Student>();


        public Course()
        {

        }
        public Course(string Name, int Duaration, int StudentsCount) : this()
        {
            this.Name = Name;
            this.Duaration = Duaration;
            this.StudentsCount = StudentsCount;
            CourseAutoIncriment++;
            this.courseId = CourseAutoIncriment;
        }
        public void AddStudentToCourse(Student AssignedStudent)
        {
            Console.WriteLine("Course - {0}", AssignedStudent.course.Name);
            int CourseFull = this.ListCourseStudent.Count(x => x.course.courseId == AssignedStudent.course.courseId);
            var existsStudent = this.ListCourseStudent.Find(x => x.studentId == AssignedStudent.studentId);
            if (AssignedStudent.course.StudentsCount > CourseFull && existsStudent == null)
            {

                ListCourseStudent.Add(AssignedStudent);
            }
            else
            {
                throw new Exception($"Course {AssignedStudent.course.Name} is already full!");
            }

            foreach (var item in ListCourseStudent)
            {
                Console.WriteLine("name {0}", item.name);
            }

        }


        public override string ToString()
        {
            return Name;
        }




    }
}