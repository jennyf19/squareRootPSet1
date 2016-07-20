using System;

namespace squareRootPSet1
{
    class Program
    {
        static void Main(string[] args)
        {
            //get number to take square root of = num
            /* int num;
             double error = 1;
             Console.WriteLine("Please give a starting number above 0.");
             num = Convert.ToInt32(Console.ReadLine());

             SquareRoot myNewSquareRoot = new SquareRoot(error);
             double answer = myNewSquareRoot.calculateSqRoot(num);

             Console.WriteLine(answer);
             Console.ReadLine();*/
            double error = 0.0001;
            SquareRoot myNewSquareRoot = new SquareRoot(error);
            StandardMethod myNewStandardMethod = new StandardMethod(error);

            Random random = new Random();
            for (int i = 0; i < 10000; i++)
            {
                double randomNum = random.NextDouble();
                double squareRoot = randomNum * 100000;
                double heron = myNewSquareRoot.calculateSqRoot(squareRoot);
                double standard = myNewStandardMethod.CalculateSqRoot(squareRoot);
                double result = heron - standard;
                if (result >= error)
                {
                    throw new Exception("You suck");
                }

            }
            Console.WriteLine("We tested 10000 answers and they were within 0.0001 of the square root.");
            Console.ReadLine();
        }

    }
}
