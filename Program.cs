using System;
using static System.Console;

namespace Capgemini.CSharp.Day2
{
    internal class StringMethod
    {
        static void Main(string[] args)
        {
            string str = "Capgemini";

            //WriteLine($"Length :{str.Length}");
            ////clone
            //string s = str.Clone() as string;
            //WriteLine($"Clone :{s}");
            //WriteLine($"Remove left space :{str.TrimStart()} ");
            //WriteLine($"trim :{ str.Trim()}");
            string st = "Good Morning Everyone";
            string[] ar = st.Split(' ');
            //foreach (string x in ar) 
            //WriteLine(x);
            WriteLine($"join string :{string.Join('-', ar)}");
         
            

            

        }
    }
}
