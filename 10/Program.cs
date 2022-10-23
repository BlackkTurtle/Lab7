using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strarray=Console.ReadLine().Split(' ');
            var NameAndAddress = new GenericBox<string, string>(strarray[0]+ strarray[1], strarray[2]);
            Console.WriteLine(NameAndAddress);
            strarray= Console.ReadLine().Split(' ');
            var NameAndBeer = new GenericBox<string, int>(strarray[0], int.Parse(strarray[1]));
            Console.WriteLine(NameAndBeer);
            strarray = Console.ReadLine().Split(' ');
            var IntegerAndDouble = new Tuple<int, double>(int.Parse(strarray[0]), double.Parse(strarray[1]));
            Console.WriteLine(IntegerAndDouble);
            Console.ReadLine();
        }
    }
}
