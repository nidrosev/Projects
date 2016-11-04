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

            Console.WriteLine("Enter size of array");
            int sizeArray = 0;
         
            int result;
            //int sizeArray = Int32.Parse(Console.ReadLine());
            while (!Int32.TryParse(Console.ReadLine(),out sizeArray));
            Program.FindElement(sizeArray);
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
