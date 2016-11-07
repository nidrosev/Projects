using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyProject
{
    class Academy
    {
        public List<Student> studentList = new List<Student>();
        public List<Course> courseList = new List<Course>();

        public int CourseId;
        public int StudentId;
        public Academy()
        {


        }

        public void AddStudentsToAcademy()
        {
            Course courses = new Course();
            this.EneterDataCourse();


        }

        public void AddStudent()
        {
            string StudentString = "";

            do
            {
                Console.WriteLine("Enter Student data:");
                StudentString = Console.ReadLine();
                if (StudentString != "quit")
                {

                    studentList.Add(this.ParseDataStudent(StudentString));
                }

            } while (StudentString != "quit");

        }

        public Student ParseDataStudent(string StudentString)
        {

            string[] studentArr = StudentString.Split(new string[] { "//" }, StringSplitOptions.RemoveEmptyEntries);
            var studentObject = new Student(studentArr[0], byte.Parse(studentArr[1]));
            return studentObject;
        }


        public void SignUp(string studentsIds)
        {
            Course courseObject = new Course();

            string[] resultArr = studentsIds.Split(new string[] { "//" }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Student ID {0}, Course Id {1}", resultArr[1], resultArr[0]);
            while (!int.TryParse(resultArr[0], out CourseId)) ;
            while (!int.TryParse(resultArr[1], out StudentId)) ;
            this.CheckStudent(StudentId);
            this.CheckCourse(CourseId);
            var existsStudent = this.studentList.Find(x => x.studentId == StudentId);
            var existsCourse = this.courseList.Find(x => x.courseId == CourseId);

            existsStudent.course = existsCourse;
            courseObject.AddStudentToCourse(existsStudent);


        }
        public void AssignStudent()
        {
            //
        }
        public int EnterCourseCapacity()
        {
            int result;
            Console.WriteLine("Please eneter a capacity of course");
            while (!int.TryParse(Console.ReadLine(), out result)) { Console.WriteLine("Error ,Please eneter a capacity of course"); };

            return result;
        }

        public void EneterDataCourse()
        {
            int Capacity = this.EnterCourseCapacity();

            string courseInfo;
            for (int i = 0; i < Capacity; i++)
            {
                Console.WriteLine("Please eneter a name, duration in hours per day ,number of students ,separated by //");
                courseInfo = Console.ReadLine();
                courseList.Add(this.ParseDataCourse(courseInfo));

            }

            foreach (var item in courseList)
            {
                Console.WriteLine($"name -{item.Name}, duration in hours per day - {item.Duaration}, number of Students - {item.StudentsCount}, id -{item.courseId}, name - {item}");
            }

        }
        public Course ParseDataCourse(string courseInfo)
        {

            while (!courseInfo.Contains("//")) { Console.WriteLine("Error ,Please eneter a correct separator"); };

            string[] courseData = courseInfo.Split(new string[] { "//" }, StringSplitOptions.RemoveEmptyEntries);
            var p = new Course(courseData[0], int.Parse(courseData[1]), int.Parse(courseData[2]));


            return p;

        }



        public void CheckStudent(int StudentId)
        {

            var existsStudent = this.studentList.Find(x => x.studentId == StudentId);
            if (existsStudent != null)
            {
                Console.WriteLine("Student with name {0} already exist", existsStudent.name);
            }
            else
            {
                throw new Exception("Student with this id do not exist");
            }
        }

        public void CheckCourse(int CourseId)
        {

            var existsCourse = this.courseList.Find(x => x.courseId == CourseId);
            Console.WriteLine("Course test {0} exist", existsCourse.courseId);
            if (existsCourse != null)
            {
                Console.WriteLine("Course with name {0} exist", existsCourse.Name);
            }
            else
            {
                throw new Exception("Course with this id do not exist exist");
            }
        }

        public void RemoveStudent()
        {
            // StudentList.Remove(Notes.Where(note => note.Id == id).First());
        }
    }
}
