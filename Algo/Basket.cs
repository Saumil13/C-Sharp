using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo
{
    public class Basket
    {
        public static int TotalFruit(int[] tree)
        {
            int start = 0;
            int max = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int end = 0; end < tree.Length; end++)
            {
                int temp = 0;
                if (map.ContainsKey(tree[end]))
                {
                    temp = map[tree[end]];
                    map[tree[end]] = temp + 1;
                }
                else
                {
                    map.Add(tree[end], 1);
                }

                while (map.Count > 2)
                {
                    if (map[tree[start]] == 1)
                        map.Remove(tree[start]);
                    else
                    {
                        map.Add(tree[start], map[tree[start]] - 1);
                    }
                    start++;
                }

                int len = end - start + 1;
                max = Math.Max(len, max);
            }

            return max;
        }

        static void Main(string[] args)
        {
            TotalFruit(new int[] { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 });
        }
    }
}
