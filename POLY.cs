using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
    internal class POLY
    {
        String Name, City, MobileNo, BirthDate;
        double salary;

        public void AcceptDetails(string name,string city)

        {
            Name = name;
            City = city;
}
        public void AcceptDetails(string name,double sal)
        {
            Name=name;
            salary = sal;
        }
        public void AcceptDetails(string name,double salary)
        public void print()
        {
            Console.WriteLine($"employee details");
            Console.WriteLine($"name : {Name}\t city :{City}\tmobile no :{MobileNo}\t birthedate :{BirthDate}");
        }
    }
}
