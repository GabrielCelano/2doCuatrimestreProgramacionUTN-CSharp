using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorEstatico
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            A ab = new B();
            Console.ReadKey();
        }

        public class A
        {
            static A()
            {
                Console.WriteLine("hola desde A estatica!");
            }

            //public A()
            //{
            //    Console.WriteLine("hola desde A publica!");
            //}
        }

        public class B : A
        {
            public B()
            {
                Console.WriteLine("hola desde B!");
            }


        }
    }
}
