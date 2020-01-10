// ========================================================
// Generate triangle
// ========================================================
//
// TriangleStars(4);
//
// Expected result
// 1
// 12
// 123
// 1234
//
// TriangleStars(2);
//
// Expected result
// 1
// 12

using System;

namespace ChallengeApp
{
    public class TriangleOfNumbers
    {
        public static string Run(int input)
        {            
            int count = input;

            for(int i=1;i<=count;i++) {
                for(int j=1;j<=i;j++){
                    Console.Write(j);
                    
                }
                Console.Write("\n");
            }
            return null;
        
            throw new NotImplementedException();
        }
    }
}
