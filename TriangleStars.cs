// ========================================================
// Generate triangle
// ========================================================
//
// TriangleStars(5);
//
// Expected result
// *
// **
// ***
// ****
// *****
//
// TriangleStars(2);
//
// Expected result
// *
// **

using System;

namespace ChallengeApp
{
    public class TriangleStars
    {
        public static string Run(int input)
        {           
            int count = input;
            for(int i=1;i<=count;++i) {
                
                for(int j=1;j<=i;++j){
                    Console.Write("*");
                } 
                Console.Write("\n");
            }

            return null;
        
             throw new NotImplementedException();
        }
    }
}
