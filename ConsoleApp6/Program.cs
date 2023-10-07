using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s=new Stack();
            s.Push(1);
            s.Push(1.1);
            s.Push('z');
            s.Push("Hello");

            foreach(var i in s)
            { Console.WriteLine(i); }
            Console.ReadKey();

        }
    }
}
