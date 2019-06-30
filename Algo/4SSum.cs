using System;
using System.Collections.Generic;
using System.Text;

namespace Algo
{
    public class _4SSum
    {

        //Given an array nums of n integers and an integer target, are there elements a, b, c, and d in nums such that a + b + c + d = target? Find all unique quadruplets in the array which gives the sum of target.

        //Note:

        //The solution set must not contain duplicate quadruplets.

        //Example:

        //Given array nums = [1, 0, -1, 0, -2, 2], and target = 0.

        //A solution set is:
        //[
        //  [-1,  0, 0, 1],
        //  [-2, -1, 1, 2],
        //  [-2,  0, 0, 2]
        //]

        public List<List<int>> fourSum(int[] num, int target)
        {
            Array.Sort(num);
            HashSet<List<int>> hSet = new HashSet<List<int>>();
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    for (int k = j + 1, l = num.Length - 1; k < l;)
                    {
                        int sum = num[i] + num[j] + num[k] + num[l];
                        if (sum > target)
                        {
                            l--;
                        }
                        else if (sum < target)
                        {
                            k++;
                        }
                        else if (sum == target)
                        {
                            List<int> found = new List<int>();
                            found.Add(num[i]);
                            found.Add(num[j]);
                            found.Add(num[k]);
                            found.Add(num[l]);
                            if (!hSet.Contains(found))
                            {
                                hSet.Add(found);
                                result.Add(found);
                            }

                            k++;
                            l--;

                        }
                    }
                }
            }
            return result;
        }
    }
}
