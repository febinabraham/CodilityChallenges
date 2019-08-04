using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercise
{
    class MaximumBitBorder
    {
        public int solution(int N)
        {
            // Given int N find bit representation and find the maximum number of zeros
            //borderd with 1's. For example if binary rep is 10001010 then the answer is 3.
            string binaryString = Convert.ToString(N, 2);

            int max = 0; //current max is zero
            int l = binaryString.Length;
            int counter = 0;
            int pointer = 0;
            while (pointer < l && binaryString[pointer] == 0)
            {
                pointer++;

            }

            while (pointer < l)
            {

                pointer++;
                counter = 0;
                while (pointer < l && binaryString[pointer] == '0')
                {
                    counter++;
                    pointer++;
                }

                if (pointer < l && max < counter) { max = counter; }
            }
            return max;
        }
    }
}
