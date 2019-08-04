using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercise
{
    class MinimumNumberofSwaps
    {
        public bool Test(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int n = A.Length;
            int i = 0; //counter for number of swaps
            int index = 0;
          
            
            while (index < n)
            {
                var current = A[index];
                for (int j = index + 1; j < n; j++)
                {
                    if (current > A[j])
                    {
                        i++;
                    }
                }
                if( i > 1) { return false; }
                index++;

            }
            return true;

        }

        
    }
}
