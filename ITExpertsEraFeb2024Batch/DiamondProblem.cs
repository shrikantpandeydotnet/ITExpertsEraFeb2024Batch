using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraFeb2024Batch
{
    public class A
    {
        public virtual void Method1()
        {
            Console.WriteLine("Mehot 1");
        }
    }
    public class B : A
    {
        public override void Method1()
        {
            Console.WriteLine("Mehot 1 override by B class");
        }
    }

    public class C : A
    {
        public override void Method1()
        {
            Console.WriteLine("Mehot 1 override by C class");
        }

    }

    public class D:B
    {
        
    }

    // D obj = new D(); obj.Method1();





   
}
