//숫자가 클 경우 터짐

using System.Collections.Generic;

namespace CountPrimes
{
    class Solution
    {
        public int CountPrimes(int n)
        {
            if (n < 3)
            {
                return 0;
            }

            List<int> primeSet = new List<int>();
            primeSet.Add(2);

            int i;
            for (i = 3; i < n; i++)
            {
                for (int j = 0; j <= primeSet.Count; j++)
                {
                    if (j == primeSet.Count)
                    {
                        primeSet.Add(i);
                        break;
                    }

                    else if (i % primeSet[j] == 0)
                    {
                        break;
                    }
                }

            }

            return primeSet.Count;
        }
    }
}
