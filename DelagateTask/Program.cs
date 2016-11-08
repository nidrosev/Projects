using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static DelagateTask.Operation;

namespace DelagateTask
{
    public delegate int PerformCalculation(int x, int y);
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a first integer");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second integer");
            int secondNumber = int.Parse(Console.ReadLine());
           
            
            Console.WriteLine("enter operation");
            string operation = Console.ReadLine();

            FactoryOp factoryOp = new FactoryOp();


            Console.WriteLine("{0}", factoryOp.FactoryOpMethod(operation, firstNumber, secondNumber));
            Console.ReadKey();



        }
    }
}
