using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace squareRootPSet1
{
    class Program
    {
        static void Main(string[] args)
        {
            //get number to take square root of = num
            int num;
            double error = 1;
            Console.WriteLine("Please give a starting number above 0.");
            num = Convert.ToInt32(Console.ReadLine());

            SquareRoot myNewSquareRoot = new SquareRoot(error);
            double answer = myNewSquareRoot.calculateSqRoot(num);

            Console.WriteLine(answer);
            Console.ReadLine();
        }

        //class square root
    }
}
