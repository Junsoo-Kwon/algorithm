/*
 * Algorithm Day 5
 * BestTimeToBuyAndSellStock
 * https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
 * 
 * 44.87% 속도
 */

namespace BestTimeToBuyAndSellStock
{
    class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int minValue = prices[0];
            int maxValue = prices[0];
            int maxProfitValue = 0;

            //O(n)의 속도
            for (int i = 1; i < prices.Length; i++)
            {
                //0번 값보다 작을 경우 새롭게 초기화
                if(prices[i] < minValue)
                {
                    minValue = prices[i];
                    maxValue = 0;
                    continue;
                    //최저가 갱신함으로 최대값 구할 필요 없음
                }
                
                if(prices[i] > maxValue)
                {
                    maxValue = prices[i];

                    //최댓값이 갱신되었지만 최대이익이 갱신되었는지는 상황에 따라 다르기에
                    if(maxProfitValue < maxValue - minValue)
                    {
                        maxProfitValue = maxValue - minValue;
                    }
                }
            }
            return maxProfitValue;
        }
    }
}
