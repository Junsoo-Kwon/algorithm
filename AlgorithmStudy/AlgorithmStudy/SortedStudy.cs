//Day 8
//Sort Study

namespace SortedStudy
{
    class Solution
    {
        void Swap(ref int[] nums, int num1, int num2)
        {
            int temp = nums[num1];
            nums[num1] = nums[num2];
            nums[num2] = temp;
        }

        //min: O(n^2) Max: O(n^2) / memory : O(1) / Stability
        public int[] BubbleSort(ref int[] nums)
        {
            for (int j = 0; j < nums.Length - 1; j++)
            {
                for (int i = 0; i < nums.Length - 1 - j; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        Swap(ref nums, i, i + 1);
                    }
                }
            }

            return nums;
        }

        //min: O(n^2) Max: O(n^2) / memory : O(1) / Non stability
        public int[] SelectSort(ref int[] nums)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                for (int i = 0 + j; i < nums.Length; i++)
                {
                    if (nums[j] > nums[i])
                    {
                        Swap(ref nums, i, j);
                    }
                }
            }

            return nums;
        }

        //min: O(n^2) Max: O(n^2) / memory : O(1) / Stability
        public int[] InsertionSort(ref int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                int numsIndex = i;
                while (nums[numsIndex - 1] > nums[numsIndex])
                {
                    Swap(ref nums, numsIndex, numsIndex - 1);
                    numsIndex--;
                    if(numsIndex == 0)
                    {
                        break;
                    }
                }
            }

            return nums;
        }

        //min: O(n log n) Max: O(n^2) / memory : O(log n) / non Stablilty
        #region QuickSort
        public int[] QuickSort(ref int[] nums)
        {

            QuickSortRecursive(ref nums, 0, nums.Length - 1);

            return nums;
        }

        void QuickSortRecursive(ref int[] nums, int left, int right)
        {
            if(left >= right)
            {
                return;
            }

            int pivotPos = Partition(ref nums, left, right);

            QuickSortRecursive(ref nums, left, pivotPos - 1);
            QuickSortRecursive(ref nums, pivotPos + 1, right);
        }

        int Partition(ref int[] nums, int left, int right)
        {
            int pivot = nums[right];

            int i = left - 1;
            for (int j = left; j < right; ++j)
            {
                if(nums[j] < pivot)
                {
                    ++i;
                    Swap(ref nums, i, j);
                }
            }

            int pivotPos = i + 1;
            Swap(ref nums, pivotPos, right);

            return pivotPos;
        }
        #endregion


    }
}
