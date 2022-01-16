/* 20210811
HappyNumber with Cpp
4ms, Faster than 41.27 % of Cpp

*/

#pragma once
#include <iostream>
#include <vector>

using namespace std;

bool isHappy(int n)
{
	int sum = 0;
	int target = 0;

	vector<int> sumVector;

	while (true)
	{
		while (n > 0)
		{
			target = n % 10;
			sum += (target * target);
			n = n / 10;
		}

		for (int i = 0; i < sumVector.size(); i++)
		{
			if (sumVector[i] == sum)
			{
				return false;
			}
		}

		if (sum == 1)
		{
			return true;
		}

		else
		{
			sumVector.push_back(sum);
			n = sum;
			target = 0;
			sum = 0;
		}
	}
}