using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string CountOff(int order)
        {
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
