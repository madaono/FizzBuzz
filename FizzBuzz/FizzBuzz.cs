using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string CountOff(int order)
        {
//            need refactor,too much if
            if (order.ToString().Contains("5"))
            {
                if (order % 7 == 0 && order % 5 == 0)
                {
                    return "BuzzWhizz";
                }

                return "Buzz";
            }
            if (order.ToString().Contains("3"))
            {
                return "Fizz";
            }
            if (order % 7 == 0 && order % 5 == 0 && order % 3 == 0)
            {
                return "FizzBuzzWhizz";
            }
            if (order % 7 == 0 && order % 5 == 0)
            {
                return "BuzzWhizz";
            }
            if (order % 7 == 0  && order % 3 == 0)
            {
                return "FizzWhizz";
            }
            if (order % 5 == 0 && order % 3 == 0)
            {
                return "FizzBuzz";
            }
            
            if (order % 3 == 0)
            {
                return "Fizz";
            }

            if (order % 5 == 0)
            {
                return "Buzz";
            }

            if (order % 7 == 0)
            {
                return "Whizz";
            }

            return order.ToString();
        }
    }
    
    
}
