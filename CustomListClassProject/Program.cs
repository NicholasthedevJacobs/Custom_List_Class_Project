using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomBuiltList<int> user = new CustomBuiltList<int>();
            int value1 = 1;
            int value5 = 2;
            int value3 = 3;
            user.AddToList(value1);
            user.AddToList(value3);
            user.AddToList(value5);
            Console.WriteLine(user);
            Console.ReadLine();

            //{

            //    Console.WriteLine(flamingo);
            //}
        }
    }
}
