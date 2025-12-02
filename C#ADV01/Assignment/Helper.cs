using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Helper
    {

        public static void ReverseList(ArrayList list)
        {
            for (int i = 0; i < list.Count / 2; i++)
            {
                object Temp = list[i];
                list[i] = list[list.Count - 1 - i];
                list[list.Count - 1 - i] = Temp;


            }
        }

        public static int FirstNonRepeatedChar(string str) { 
        
        Dictionary<char , int> keyValuePairs = new Dictionary<char , int>();
            
            foreach (char c in str) {
                if (keyValuePairs.ContainsKey(c)) {
                    keyValuePairs[c]++;
                }
                else
                {
                    keyValuePairs[c] = 1;
                }
            
            }
           for (int i = 0; i < str.Length; i++)
            {
                if (keyValuePairs[str[i]] == 1)
                {
                    return i;
                }
            }
           return -1;


        }


    }
}
