using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraFeb2024Batch
{
    public class MathsOperations
    {
        int var1 = 100;

        // Methods

        public int Sum(int a, int b)
        {
            var1 = 32000;
            int result = a + b;
            return result;
        }


        // methods with array

        public int Sum(int[] array1, int a)
        {
            int result = 0;

            foreach (int value in array1)
            {
                result += value;
            }

            return result;
        }

        // return type as array
        public int[] ArrayfromNumber(int a, int b, int c)
        {
            int[] result = new int[3];
            result[0] = a;  
            result[1] = b;  
            result[2] = c;

            return result;
        }

        // params keyword
        public int Sum(int a,int b, int c,  params int[] array1)
        {
            int result = 0;

            foreach (var item in array1)
            {
                result += item;
            }

            return result;
        }


    }
}
