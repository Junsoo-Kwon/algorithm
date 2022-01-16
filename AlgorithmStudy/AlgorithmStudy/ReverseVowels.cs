using System.Collections.Generic;

namespace ReverseVowels
{
    class Solution
    {
        public string ReverseVowels(string s)
        {
            char[] Vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

            char[] StoChar;
            StoChar = s.ToCharArray();

            char Swap;

            List<int> targetNumber = new List<int>();

            for (int i = 0; i < StoChar.Length; i++)
            {
                for (int j = 0; j < Vowels.Length; j++)
                {
                    if (StoChar[i] == Vowels[j])
                    {
                        targetNumber.Add(i);
                    }
                }
            }
            
            for (int j = 0; j < targetNumber.Count / 2; j++)
            {
                Swap = StoChar[targetNumber[j]];
                StoChar[targetNumber[j]] = StoChar[targetNumber[(targetNumber.Count - 1) - j]];
                StoChar[targetNumber[(targetNumber.Count - 1) - j]] = Swap;
            }
            
            s = new string(StoChar);
            return s;
        }
    }
}
