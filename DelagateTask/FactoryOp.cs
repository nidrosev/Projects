using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagateTask
{
    class FactoryOp
    {
        public int FactoryOpMethod(string oparatorType, int firstNumber, int secondNumber)
        {
            Operator oparator = (Operator)Enum.Parse(typeof(Operator), oparatorType);
            PerformCalculation opDel = null;

            switch (oparator)
            {
                case Operator.Substract:
                  
                    opDel = DelagateOperators.Substract;

                    break;
                case Operator.Multiply:
                   
                    opDel = DelagateOperators.Multiply;

                    break;
                case Operator.Additional:
                  
                    opDel = DelagateOperators.Additional;
                    break;
            }

            return opDel(firstNumber, secondNumber);
        }

    }
}
