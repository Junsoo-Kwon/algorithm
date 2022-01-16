//20210715
//https://leetcode.com/problems/reverse-string-ii/

namespace ReverseStringII
{
    class Solution
    {
        public string ReverseStr(string s, int k)
        {

            char Swap;
            char[] arr;
            arr = s.ToCharArray();

            int Min = 0;
            int Max = 0;
            int i = 0;

            for (; (2 * k * i) + (k - 1) < s.Length; i++)
            {
                Min = (2 * k * i);
                Max = (2 * k * i) + (k - 1);

                while (Min < Max)
                {
                    Swap = arr[Min];
                    arr[Min] = s[Max];
                    arr[Max] = Swap;

                    Min++;
                    Max--;
                }
            }

            if (s.Length % k != 0)
            {
                Min = (2 * k * i);
                Max = s.Length - 1;

                while (Min < Max)
                {
                    Swap = arr[Min];
                    arr[Min] = s[Max];
                    arr[Max] = Swap;

                    Min++;
                    Max--;
                }
            }

            s = new string(arr);
            return s;
        }
    }
}
