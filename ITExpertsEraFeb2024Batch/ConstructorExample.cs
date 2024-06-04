using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraFeb2024Batch
{
    public class ConstructorExample
    {
        public int varInt;
        public string varString;

        public static int StaticVarInt;
        public ConstructorExample()
        {
            varInt = 100;
            varString = "test";
        }

        public ConstructorExample(int varInt, string varString)
        {
            this.varString = varString;
            this.varInt = varInt;
        }

        public ConstructorExample(string varString2, string varString, int varInt)
        {
            this.varString = varString;
            this.varInt = varInt;
        }

        public ConstructorExample(ConstructorExample obj)
        {
            this.varInt = obj.varInt;
            this.varString = obj.varString;
        }

        static ConstructorExample()
        {
            StaticVarInt = 100;
        }
    }
}
