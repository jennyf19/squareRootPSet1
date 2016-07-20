using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareRootPSet1
{
    public class SquareRoot
    {
        public double errorLimit;

        //constructor to take acceptable error limit
        public SquareRoot(double error)
        {
            errorLimit = error;
        }

        //method to determine square root:
        public double calculateSqRoot(double num)
        {
            if (num <= 0)
            {
                throw new ArgumentOutOfRangeException("The number you gave was not greater than 0.");
                //Console.WriteLine("Please enter a number greater than 0.");
            }

            //Start with a guess number G (guess)
            double guess = num / 2;
            bool answer = checkGuess(guess, num);
            if (answer == true)
            {
                return guess;
            }

            //otherwise, compute guess = (guess + num/guess)/2 and iterate
            guess = (guess + num / guess) / 2;
            bool compute = checkGuess(guess, num);
            if (compute == true)
            {
                return guess;
            }
            while (answer == false)
            {
                //start w/a guess
                guess = (guess + num / guess) / 2;
                //check if guess is within error range
                answer = checkGuess(guess, num);
            }
            return guess;
        }

        private bool checkGuess(double guess, double num)
        {
            //if guess * guess is close enough to num, then return guess
            double product = guess * guess;
            double difference = product - num;
            if (difference <= errorLimit)
                return true;
            else
            {
                return false;
            }
        }
    }

}

