//20210708
//Teemo Attacking
//https://leetcode.com/problems/teemo-attacking/
//7.79 % of csharp



namespace TeemoAttacking
{
    class Solution
    {
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            #region timeSeries 와 duration이 클 경우 time over
            /*  
            //https://leetcode.com/submissions/detail/519291691/의 경우 시간 제한초과

            HashSet<int> timeSet = new HashSet<int>();
           
            for (int i = 0; i < timeSeries.Length; i++)
            {
                for (int j = 0; j < duration; j++)
                {
                    if(!(timeSet.Contains(timeSeries[i] + j)))
                    {
                        timeSet.Add(timeSeries[i] + j);
                    }
                }
            }

            return timeSet.Count;
            */
            #endregion

            int posionedDuration = duration;

            for (int i = timeSeries.Length - 2; i >= 0; i--)
            {
                int diff = timeSeries[i + 1] - timeSeries[i];

                if(diff < duration)
                {
                    posionedDuration = posionedDuration + diff;
                }

                else
                {
                    posionedDuration = posionedDuration + duration;
                }
            }

            return posionedDuration;
        }
    }
}
