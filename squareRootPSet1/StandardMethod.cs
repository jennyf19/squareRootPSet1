using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareRootPSet1
{
    class StandardMethod : ISqrRt
    {
        public double errorLimit;

        //constructor to take acceptable error limit
        public StandardMethod(double error)
        {
            errorLimit = error;
        }

        //method to determine square root:
        public double SquareRoot(double num)
        {
            if (num <= 0)
            {
                throw new ArgumentOutOfRangeException("The number you gave was not greater than 0.");
                //Console.WriteLine("Please enter a number greater than 0.");
            }
            double answerNum = Math.Sqrt(num);
            return answerNum;
        }
    }
}
