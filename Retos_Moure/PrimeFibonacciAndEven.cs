using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retos_Moure
{
    public class PrimeFibonacciAndEven
    {
        private string _result = String.Empty;
        private string _pair = String.Empty;
        private string _prime = String.Empty;
        private string _fibonacci = String.Empty;

        private bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0)
                    return false;

            return true;
        }

        private bool IsFibonacci(int num)
        {
            int a = 0;
            int b = 1;
            while (b < num)
            {
                int temp = b;
                b += a;
                a = temp;
            }
            return b == num;
        }

        public string proof(int numberToProof) 
        {
            _pair = (numberToProof % 2 == 0) ? "pair" : "unpair";
            _prime = (IsPrime(numberToProof)) ? "is" : "is not";
            _fibonacci = (IsFibonacci(numberToProof)) ? "is" : "is not";

            _result = String.Format("{0} {1} prime, {2} Fibonacci and is {3}", numberToProof, _prime, _fibonacci, _pair);
            return _result;
        }
    }
}
