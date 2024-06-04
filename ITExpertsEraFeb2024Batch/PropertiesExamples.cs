using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraFeb2024Batch
{
    public class PropertiesExamples
    {

        private int abc; 

       public int TestProperty
        {
            get
            {
                return abc;
            }
            set
            {
                abc = value;
            }
        }

        //Properties. Automated property or Auto Implemented Property. 
        public int Size { get; set; }

        // Read only property

        public int MyProperty { get; private set; }


        // write only 

        public int WriteOnlyProperty { private get; set; }


        public void SetMyPropert()
        {
            MyProperty = 10;

            Console.WriteLine(WriteOnlyProperty);
        }
    }
}
