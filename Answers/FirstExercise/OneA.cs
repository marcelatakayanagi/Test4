using System;
using System.Collections.Generic;

namespace Answers
{
    public static class OneA
    {
        public static List<int> Numbers(int[] array)
        {
            List<int> numbers = new List<int>();

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > 50)
                {
                    if (array[i] % 9 == 0)
                    {
                        numbers.Add(array[i]);
                    }
                }
            }
            return numbers;
        }
    }

  
}
