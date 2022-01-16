/* 2021 08 09
 * Faster than 84.20% C# Summision
 * Lower memory than 96.09
 */
namespace AddStrings
{
    class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            char[] num1Char = num1.ToCharArray();
            char[] num2Char = num2.ToCharArray();

            char[] sumChar = new char[(num1Char.Length >= num2Char.Length) ? num1Char.Length : num2Char.Length];

            int num1Pointer = num1Char.Length - 1;
            int num2Pointer = num2Char.Length - 1;
            int sumCharPointer = sumChar.Length - 1;

            int upper = 0;

            while (true)
            {
                sumChar[sumCharPointer] = (char)(SumInput(num1Char[num1Pointer], num2Char[num2Pointer], upper) % 10 + 48);
                upper = SumInput(num1Char[num1Pointer], num2Char[num2Pointer], upper) / 10;

                if (num1Pointer == 0 && num2Pointer == 0)
                {
                    break;
                }

                if(num1Pointer > 0)
                {
                    num1Pointer--;
                }

                else
                {
                    num1Char[0] = '0';
                }

                if(num2Pointer > 0)
                {
                    num2Pointer--;
                }

                else
                {
                    num2Char[0] = '0';
                }

                sumCharPointer--;
            }
            
            if (upper != 0)
            {
                return (char)(upper + 48) + new string(sumChar);
            }

            else
            {
                return new string(sumChar);
            }
        }

        private int SumInput(char num1Char, char num2Char, int upper)
        {
            int num1Int = 0;
            int num2Int = 0;

            switch (num1Char)
            {
                case '1':
                    num1Int = 1;
                    break;

                case '2':
                    num1Int = 2;
                    break;

                case '3':
                    num1Int = 3;
                    break;

                case '4':
                    num1Int = 4;
                    break;

                case '5':
                    num1Int = 5;
                    break;

                case '6':
                    num1Int = 6;
                    break;

                case '7':
                    num1Int = 7;
                    break;

                case '8':
                    num1Int = 8;
                    break;

                case '9':
                    num1Int = 9;
                    break;

                case '0':
                    num1Int = 0;
                    break;

                default:
                    break;
            }

            switch (num2Char)
            {
                case '1':
                    num2Int = 1;
                    break;

                case '2':
                    num2Int = 2;
                    break;

                case '3':
                    num2Int = 3;
                    break;

                case '4':
                    num2Int = 4;
                    break;

                case '5':
                    num2Int = 5;
                    break;

                case '6':
                    num2Int = 6;
                    break;

                case '7':
                    num2Int = 7;
                    break;

                case '8':
                    num2Int = 8;
                    break;

                case '9':
                    num2Int = 9;
                    break;

                case '0':
                    num2Int = 0;
                    break;

                default:
                    break;
            }

            return num1Int + num2Int + upper;
        }
    }
}
