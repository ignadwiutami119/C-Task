// ========================================================
// How many duplicates
// ========================================================

// int[] dups = {1, 3, 5, 1, 4, 5, 2, 4, 3, 5, 3, 1};
//
// Expected result
// 1 -> 3x
// 2 -> 1x
// 3 -> 3x
// 4 -> 2x
// 5 -> 2x

using System;
using System.Collections.Generic;

namespace ChallengeApp
{
    public class HowManyDuplicates
    {
        public static int[] Run()
        {
            int[] arr = {1, 3, 5, 1, 4, 5, 2, 4, 3, 5, 3, 1};
            var diction = new Dictionary<int,int>();
            foreach(int value in arr) {
                if(diction.ContainsKey(value))
                {
                    diction[value]++;
                }
                else
                {
                    diction[value]=1;
                }
            }
            foreach(var match in diction)
            {
                Console.WriteLine("jumlah {0} sebanyak {1}",match.Key, match.Value);
            }
            return arr;
            throw new NotImplementedException();
        }
    }
}
