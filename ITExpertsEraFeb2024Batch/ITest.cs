using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraFeb2024Batch
{
    public interface ITest
    {
        void Sum(int a, int b);

        void Diff(int a, int b);

        void TestMethod();

        void FirstMethod(int a);
    }

    public interface ITest2
    {
        void TestMethod2();

        void FirstMethod(int b);
    }

    public class ParentClass
    {
        public void ParentClassMethod()
        {
            Console.WriteLine("I am parent class method");
        }
    }

    public class Class1 : ParentClass, ITest, ITest2
    {
        public void Diff(int a, int b)
        {
            Console.WriteLine("Sum of the two number is " + (a + b));
        }

        void ITest.FirstMethod(int a)
        {
            Console.WriteLine("i am itest2 firstmethod");
        }

        void ITest2.FirstMethod(int a)
        {
            Console.WriteLine("i am itest2 firstmethod");
        }

        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum of the two number is " + (a - b));

        }

        public void TestMethod()
        {
            Console.WriteLine(" I am test method");
        }

        public void TestMethod2()
        {
            Console.WriteLine("I am TestMethod2");
        }

        public void childclassmethod()
        {
            Console.WriteLine("I am child class method");
        }
    }
}
