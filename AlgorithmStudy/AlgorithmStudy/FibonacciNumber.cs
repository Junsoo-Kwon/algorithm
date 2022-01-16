//20210712
//FibonacciNUmber

namespace FibonacciNumber
{
    class Solution
    {
        public int Fib(int n)
        {
            int[] Fib_Array = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                if (i <= 1)
                {
                    Fib_Array[i] = i;
                }

                else
                {
                    Fib_Array[i] = Fib_Array[i - 1] + Fib_Array[i - 2];
                }
            }
            return Fib_Array[n];
        }
    }
}
