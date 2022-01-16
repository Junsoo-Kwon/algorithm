//20210811
//BestTimeToBuyAndSellStock with Cpp
//14.76 % ¼Óµµ

#pragma once
#include <vector>

using namespace std;

int maxProfit(vector<int>& prices)
{
	int minValue = prices[0];
	int maxValue = prices[0];
	int maxProfitValue = 0;

	for (size_t i = 0; i < prices.size(); i++)
	{
		if (prices[i] < minValue)
		{
			minValue = prices[i];
			maxValue = 0;
			continue;
		}

		if (prices[i] > maxValue)
		{
			maxValue = prices[i];

			if (maxProfitValue < maxValue - minValue)
			{
				maxProfitValue = maxValue - minValue;
			}
		}
	}

	return maxProfitValue;
}