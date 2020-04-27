using System;
using System.Collections.Generic;

namespace Answers
{
    public class OneC
    {
        public static List<double> Ex2C(List<int> numbers)
        {
            List<double> newList = new List<double>();

            for ( int i = 0; i < numbers.Count; i++)
            {
                double newNumber = Math.Pow(Convert.ToDouble(numbers[i]), 2.0)+8*3;
                newList.Add(newNumber);
            }

            return newList;
        }
    }

}
