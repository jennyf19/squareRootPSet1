using System;

namespace squareRootPSet1
{
    public class SquareRootCalculator : ISqrRt
    {
        private readonly double _errorLimit;

        //constructor to take acceptable error limit
        public SquareRootCalculator(double error)
        {
            _errorLimit = error;
        }

        //method to determine square root:
        public double SquareRoot(double num)
        {
            if (num <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(num), "The number you gave was not greater than 0.");
                //Console.WriteLine("Please enter a number greater than 0.");
            }

            //Start with a guess number G (guess)
            double guess = num / 2;
            bool answer = CheckGuess(guess, num);
            if (answer)
            {
                return guess;
            }

            //otherwise, compute guess = (guess + num/guess)/2 and iterate
            guess = (guess + num / guess) / 2;
            bool compute = CheckGuess(guess, num);
            if (compute)
            {
                return guess;
            }
            while (answer == false)
            {
                //start w/a guess
                guess = (guess + num / guess) / 2;
                //check if guess is within error range
                answer = CheckGuess(guess, num);
            }
            return guess;
        }

        private bool CheckGuess(double guess, double num)
        {
            //if guess * guess is close enough to num, then return guess
            double product = guess * guess;
            double difference = product - num;
            if (difference < _errorLimit)
                return true;
            else
            {
                return false;
            }
        }
    }

}

