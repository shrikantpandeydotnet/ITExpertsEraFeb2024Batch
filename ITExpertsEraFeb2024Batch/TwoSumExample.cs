using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraFeb2024Batch
{
    public class TwoSumExample
    {
        // 6, 3, 12, 4, 5 | 10 
        public int[] TwoSumProblem(int[] arrayInt, int target)
        {
            int[] result = new int[2];

            Dictionary<int, int> dictValues = new Dictionary<int, int>();

            for (int i = 0; i < arrayInt.Length; i++)
            {
                int num = arrayInt[i]; // 4

                int prevnum = target - num; // 6

                if (dictValues.ContainsKey(prevnum))
                {
                    result[0] = i; 
                    result[1] = dictValues[prevnum];
                }
                else
                {
                    dictValues[num] = i;  // key, value = 12, 2
                }
            }

            return result;
        }
    }
}
