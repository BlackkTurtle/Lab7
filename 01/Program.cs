using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            try
            {
                int a= int.Parse(str);
                var result=new GenericBox<int>(a);
                Console.WriteLine(result.ToString());
            }
            catch (Exception)
            {
                var result=new GenericBox<string>(str);
                Console.WriteLine(result.ToString());
            }
            Console.ReadLine();
        }
    }
}
