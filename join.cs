using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
    internal class join
    {
        static void Main(string[] args)
        {

            string st = "Good Morning Everyone";
            string[] ar = st.Split(' ');
            Write($"join string :{string.Join('-', ar)}");
        }
    }
}
