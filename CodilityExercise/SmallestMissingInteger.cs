using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercise
{
    class SmallestMissingInteger
    {
        public int FindSmallestMissingInteger(int[] A)
        {
            Array.Sort(A);//sort the array in ascending order : Complexity?
            int i = Array.FindIndex(A, (x) => x > 0);
            if( i == -1) { return 1; }//No positive elements
            else
            {                
                if (A[i] > 1) { return 1; }//first element greater than 1?
                int j = 2;//For comparison
                while (i < A.Length)
                {
                    //skip to the next element if repeating numbers
                    while (i < A.Length - 1 && A[i] == A[i + 1])
                    {
                        i++;
                    }

                    if (i == A.Length - 1) { return A[A.Length - 1] + 1; }//Return next positive number if end is reached
                    i++;//go to next number
                    if (A[i] != j) { return j; }//compare with the next smallest integer
                    j++;//Go to the next smallest integer

                }
                return 0;

            }


        }
    }
}
