using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraFeb2024Batch
{
   public class Parent
    {
        //test
        public Parent() //1
        {
            Console.WriteLine("I am parent class constructor");  
        }

        static Parent() // 2
        {
            Console.WriteLine("I am static parent class constructor");
        }
        public void ParentMethod()
        {
            Console.WriteLine("I am Parent Method");
        }

        public virtual void ParentMethod2()
        {
            Console.WriteLine("I am Virtual Parent Method");
        }

    }

    public class Child : Parent
    {
        public Child() // 3
        {
            Console.WriteLine("I am child class constructor");
        }

        static Child() // 4
        {
            Console.WriteLine("I am static child class constructor");

        }
        public void ChildMethod() 
        {
            Console.WriteLine("I am child method");
        }

        public  override void ParentMethod2()
        {
            Console.WriteLine("I am Changed Override Parent Method in child claass");
        }

        public new void ParentMethod()
        {
            Console.WriteLine("I am new Parent Method in child class");
        }
    }

    public class Child2: Parent
    {
        public void Child2Method()
        {
            Console.WriteLine("I am child 2 method");
        }
    }

    public class GrandChild : Child
    {
        public void GrandChildMethod()
        {
            Console.WriteLine("I am grandchild method");
        }

        public override void ParentMethod2()
        {
            Console.WriteLine("I am Changed Override Parent Method in Grand child claass");
        }
    }

}
