
using Line.Handler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessIsBetterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LessIsBetter lessIsBetter = new LessIsBetter();
            Console.WriteLine(lessIsBetter.Order(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
