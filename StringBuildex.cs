using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
    internal class StringBuildex
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string m;
            do
            {
                Console.WriteLine("Enter message");
                m = Console.ReadLine();
                sb.AppendLine(m);

            } while (m.ToLower() != "no");
            Console.WriteLine(sb.ToString());

        }
    }
}
