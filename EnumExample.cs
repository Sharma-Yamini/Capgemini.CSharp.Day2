using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
  
        enum Fruits
        {
            Apple=123,
            Banana=789,
            Pears,
            Orange,
            Grapes=888
        }
    internal class EnumExample
    {
        static void Main(string[] args)
        {
           foreach (var k in Enum.GetNames(typeof(Fruits)))
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("Enum Values");
            foreach (int k1 in Enum.GetValues(typeof(Fruits)))
                Console.WriteLine(k1);

        }
    }
}
