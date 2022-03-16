using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini.CSharp.Day2
{
    //internal class StructExample
    //{
    //   public int Id;
    //    public string Name;
    //    public double salary;

    //    public void store()
    //    {
    //        Id = 1000;
    //        Name = "yami";
    //        salary = 25000;
    //    }
    //}
    struct StructExample1
    {
        public int Id;
        public string Name;
        public double salary;

    }
    class executeclass
    {



        static void Main(string[] args)
        {
            //StructExample example = new StructExample();
            // example.store();
            // Console.WriteLine($"ID is :{example.Id}\t Name is :{example.Name}\tSalary is :{example.salary}");
            StructExample1 obj;
            obj.Id = 1987;
            obj.Name = "vand";
            obj.salary = 23453;
            Console.WriteLine($"ID is :{obj.Id}\t Name is :{obj.Name}\tSalary is :{obj.salary}");
        }
    }
}
