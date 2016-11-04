using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int UserChoice = 0;
            Console.WriteLine("Please Choose an operation");
            Console.WriteLine("Press 1 to Enter a course");
            Console.WriteLine("Press 2 to Enter a students");
            Console.WriteLine("Press 3 to Check if student exists by name");
            Console.WriteLine("Press 4 to Remove student from list");
            Console.WriteLine("Press 5 to Assign student to course");
            while (!int.TryParse(Console.ReadLine(), out UserChoice)) { Console.WriteLine("Please enter correct number"); };

            switch (UserChoice)
            {
                case 1 :
                    Course courses = new Course();
                    courses.EneterDataCourse();

                    break;
                case 2:
                    Student student = new Student();

                    student.EnterData();
                    break;
                case 3:
                    Student studentCheck = new Student();

                    studentCheck.CheckStudent();
                    break;
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        public static void FindElement(int sizeArray)
        {
            int[][] myArray = new int[sizeArray][];
            Console.WriteLine("sizeArray {0}", sizeArray);
            int k = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new int[sizeArray];
                for (int j = 0; j < myArray.Length; j++)
                {
                    k++;
                    myArray[i][j] = k;

                }

            }
            Console.WriteLine("Enter  First and Second number");
            int FirstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            int SecondNumber = Int32.Parse(Console.ReadLine());

            // while (!Int32.TryParse(myArray[FirstNumber][SecondNumber], out result));
            try
            {
                Console.WriteLine("The result is:  {0}", myArray[FirstNumber][SecondNumber]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error please try again");
            }

            //Console.WriteLine("The result is:  {0}", myArray[FirstNumber][SecondNumber]);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
