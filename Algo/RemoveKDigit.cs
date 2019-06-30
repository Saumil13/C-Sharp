using System;
using System.Collections.Generic;
using System.Text;

namespace Algo
{
    public class RemoveKDigit
    {
        //Input: num = "1432219", k = 3
        //Output: "1219"
        //Explanation: Remove the three digits 4, 3, and 2 to form the new number 1219 which is the smallest

        public String removeKdigits(String num, int k)
        {
            if (num.Length == k)
                return "0";

            StringBuilder sb = new StringBuilder(num);
            for (int j = 0; j < k; j++)
            {
                int i = 0;
                while (i < sb.Length - 1 && sb[i] <= sb[i + 1])
                {
                    i++;
                }
                sb.Remove(i, i + 1);
            }

            //remove leading 0's        
            while (sb.Length > 1 && sb[0] == '0')
                sb.Remove(0, 1);

            if (sb.Length == 0)
            {
                return "0";
            }

            return sb.ToString();
        }
    }
}
