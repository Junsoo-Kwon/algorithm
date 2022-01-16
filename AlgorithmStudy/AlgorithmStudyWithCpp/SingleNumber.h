//20210811
//SingleNumber

#pragma once

#include<vector>

using namespace std;

int singleNumber(vector<int>& nums)
{
	vector<int> keyVector;
	keyVector.reserve(nums.size() / 2 + 1);

	for (vector<int>::iterator j = nums.begin(); j != nums.end(); ++j)
	{
		vector<int>::iterator i = keyVector.begin();
		
		if (i == keyVector.end())
		{
			keyVector.push_back(*j);
		}

		else
		{
			for (i; i != keyVector.end(); ++i)
			{
				if (*j == *i)
				{
					keyVector.erase(i);
					break;
				}

				else if (i == keyVector.end() - 1)
				{
					keyVector.push_back(*j);
					break;
				}
			}
		}
	}

	return *keyVector.begin();
}