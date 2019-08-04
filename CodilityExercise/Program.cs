using System;
using System.Linq;
using System.Collections.Generic;

namespace CodilityExercise
{
    class Program
    {


        static void Main(string[] args)
        {


            Console.WriteLine(solution(112));

            Console.Read();
        }

        public static int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string[] numbers = N.ToString().Split(' '); //Split each number in N
            List<int> familyOfN = new List<int>(); //List to add each number in family of N
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = 1; j < numbers.Length;j++)
                {
                    for(int k = 2; k < numbers.Length; k++)
                    {
                        if ((i == j) && (j == k))
                            break;
                        int member = Convert.ToInt32(numbers[i] + numbers[j] + numbers[k]);
                        familyOfN.Add(member);
                    }
                }
            }
            return familyOfN.Max();
        }
    }
    
}
