using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algo
{
    public class GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams1(string[] strs)
        {

            Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                var hash = string.Concat(str.OrderBy(c => c));

                if (anagrams.ContainsKey(hash))
                {
                    anagrams[hash].Add(str);
                }
                else
                {
                    anagrams.Add(hash, new List<string> { str });
                }
            }

            return anagrams.Values.ToArray();
        }
    }
}
