using System;
using System.Runtime.Remoting;

namespace squareRootPSet1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*SquareRootCalculator myNewSquareRootCalculator = new SquareRootCalculator(error);
             double answer = myNewSquareRootCalculator.SquareRootCalculator(num);*/

            double error = 0.0001;
            SquareRootCalculator myNewSquareRootCalculator = new SquareRootCalculator(error);
            StandardMethod myNewStandardMethod = new StandardMethod(error);
            bool finalResult = CatScratcher(myNewSquareRootCalculator, myNewStandardMethod, error);
        }

        public static bool CatScratcher(ISqrRt brio, ISqrRt stormy, double error)
        {   
            //generate 10000 random numbers from 0-100000
            //compute squareroot from both classes (brio using heron and stormy using standard)
            //validate the difference between the two results is under the error rate
            Random random = new Random();
            for (int i = 0; i < 10000; i++)
            {
                double randomNum = random.NextDouble();
                double squareRoot = randomNum * 100000;
                double heron = brio.SquareRoot(squareRoot);
                double standard = stormy.SquareRoot(squareRoot);
                double result = heron - standard;
                if (result >= error)
                {
                    return false;
                }
            }
            Console.WriteLine("We tested 10000 answers and they were within 0.0001 of the square root.");
            Console.ReadLine();
            return true;
        }

    }
}
