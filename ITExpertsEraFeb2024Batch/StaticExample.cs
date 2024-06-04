using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraFeb2024Batch
{
    public class StaticExample
    {

        public int varInt;

        public static int StaticVArInt;

        public static void TestMethod()
        {
            Console.WriteLine(" I am static method");

            // you can only declare 
            StaticVArInt = 200;
        }

        public void TestMeMethod2()
        {
            varInt = 200;

            StaticVArInt = 90;
        }
    }
}
