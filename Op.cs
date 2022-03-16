using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
    internal class Calc
    {

        int X, Y, sum;
        public Calc()
        {

        }
        public Calc(int a, int b)
        {
            X = a;
            Y = b;

        }
        public void print()
        {
            Console.WriteLine($"x : {X}\t y : {Y}\t sum : {sum}");
        }
        public static Calc operator +(Calc c1)
        {
            c1.sum = c1.X + c1.Y;
            return c1;
        }
        static void Main(string[] args)
        {
            Calc calc1 = new Calc();
            calc1.print();
        }
    }
}
