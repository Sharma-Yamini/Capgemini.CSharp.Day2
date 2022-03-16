using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
    public class AccessModifier
    {
        public string UserId;
       // private string Password;
        internal string City;

    }
    
    
    public class Test 
    {

    
        static void Main(string[] args)
        {
            AccessModifier a1 = new AccessModifier();
            a1.UserId = "admin";
            a1.City = "kolkata";
            

        }
    }
}
