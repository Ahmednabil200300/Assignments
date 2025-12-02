using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class EvenNumber
    {
        public static List<int> EvenNumbers(List<int> numbers) 
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++) {
                if (numbers[i] % 2 == 0)
                {
                    result.Add(numbers[i]);
                }
            }
            return result;
        }
    }
}
