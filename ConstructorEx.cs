using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
    internal class ConstructorEx
    {
        //member varialbles
      public  int Id ;
       public int Age;
      public  string name;
       public static string city = "NA";
        public const float ap = 1000.45f;
        public readonly double pr = 10000;


        //Explicit Default Constructor
        public ConstructorEx()
        {
            Id = 1000;
             Age = 45;
             name= "apple";
            
        }
        //~ConstructorEx()
        //{
        //    Console.WriteLine("Deconstructor Called");
        //}
        public void Print()
        {
            // int id = 10001;//method level variable
            Console.WriteLine($"Id :{Id}\tName : {name}\tAge :{Age}\t readonly : {pr}");
        }
        static void Main(string[] args)
        {
            //ClassNmae ObjectName=new DefaultConstructor();//new-used to allocate new memory
            ConstructorEx c = new ConstructorEx();
            c.Print();
            ConstructorEx c2 = new ConstructorEx();
            c2.Print();
            

            //static variable
            Console.WriteLine($"static variable :{ConstructorEx.city}");
            ConstructorEx.city = "kolkata";
            Console.WriteLine($"static variable { ConstructorEx.city}");
            t t1=new t();
            t1.test();
            Console.WriteLine($"Constant  variable { ConstructorEx.ap}");
        }
    }
    class t
    {
        public void test()
        {
            ConstructorEx c1 = new ConstructorEx();
            c1.Print();
            Console.WriteLine($"static variable { ConstructorEx.city}");

        }
    }


}
