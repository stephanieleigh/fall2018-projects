using System;
using static System.Console;

namespace CS_AbstractClasses
{
    class MyClass
    {
        protected void Howdy()
        {
            WriteLine("Hello from MyClass");
        }
    }
    abstract class TestAbstractClass
    {
        int i = 4;
        int k = 3;
        public abstract void GetClassName();
        public void HelloFromAbstract()
        {
            WriteLine("Some Method");
        }
    }
    interface TestInterface
    {
        void getMethod();
        string getName();
    }
    class Program : TestAbstractClass, TestInterface
    {
        static void Main(string[] args)
        {
            

            ReadLine();
        }
        public override void GetClassName()
        {
            WriteLine("Programming Class");
        }

        public void getMethod()
        {
            WriteLine("Get Method");
        }

        public string getName()
        {
            return ("some name");
        }
    }
    class Test1: MyClass
    {
        public void Example()
        {
            MyClass mc1 = new MyClass();
            Howdy();
            WriteLine("Hello");
        }
    }
}
