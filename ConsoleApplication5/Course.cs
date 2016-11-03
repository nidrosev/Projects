using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Course : Person
    {
        public string Name { get; set; }
        public int StudentsCount { get; set; }
        public int Capacity { get; set; }
        public int Duaration { get; set; }
        public int autoIncriment = 0;


        public Course()
        {

        }
        public Course(string Name, int Duaration,int StudentsCount, int autoIncriment) :this()
        {
            this.Name = Name;
            this.Duaration = Duaration;
            this.StudentsCount = StudentsCount;
            this.autoIncriment = autoIncriment;
        }

        public override string ToString()
        {
            return Name;
        }

        public int EnterCourseCapacity ()
        {
            int result;
            Console.WriteLine("Please eneter a capacity of course");
            while (!int.TryParse(Console.ReadLine(), out result)) { Console.WriteLine("Error ,Please eneter a capacity of course"); }  ;

            return result;
        }
        
        public void EneterDataCourse()
        {
            int Capacity = this.EnterCourseCapacity();
            var courseList = new List<Course>();
            string courseInfo ;             
            for (int i=0; i < Capacity; i++)
            {
                Console.WriteLine("Please eneter a name, duration in hours per day ,number of students ,separated by //");
                courseInfo = Console.ReadLine();
                courseList.Add(this.ParseDataCourse(courseInfo));
                

            }
            
              foreach (var item in courseList)
              {
               Console.WriteLine($"name -{item.Name}, duration in hours per day - {item.Duaration}, number of Students - {item.StudentsCount}, id -{item.autoIncriment}, name - {item}");
              }

            
              var student = new Student();

            Console.ReadKey();

        }
        public Course ParseDataCourse(string courseInfo)
        {
            
            while (!courseInfo.Contains("//")) { Console.WriteLine("Error ,Please eneter a correct separator");  };
            this.autoIncriment++;
            string[] courseData = courseInfo.Split(new string[] { "//" }, StringSplitOptions.RemoveEmptyEntries);
            var p = new Course(courseData[0], int.Parse(courseData[1]), int.Parse(courseData[2]), autoIncriment);
            

            return p;

        }

      

    }
}
