using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercise
{
    class DistinctValuesInBinaryTree
    {


        public int solution2(Tree T)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            List<int> numberOfValues = new List<int> { }; //List to store number of distinct values
            int j = 0; //number of passes through the tree
            if (T != null)
            {
                numberOfValues[j] = 1;//
            }
            else { return 0; }
            //starting at the root of the tree, we need to work out each valid path
            //Traverse through the tree by going to the right if there's a right tree when possible else check the left side
            Tree currentTree = T;
            while (T.r != null)
            {
                if (T.r.x == T.x) { }
                else
                {
                    numberOfValues[j] += 1;//distinct number}
                    T = T.r;
                }




                //for each of the valid paths, count the number of distinct values and add to list

                //return the max of list
                return numberOfValues.Max();

            }
            return 0;
        }

        public class Tree
        {
            public int x;
            public Tree l;
            public Tree r;
        };











        public int solutions(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int n = A[0]; //Needs at least A[0] number of strokes
            //int m = A.Length;
            for (int j = 0; j < A.Length-1;j++)
            {
                if(n>1000000000)
                {
                    return -1;
                }
                var diff = A[j + 1] - A[j];
                if(diff > 0)
                {
                    n += diff;
                }

            }
            return n;
    }
    }
}
