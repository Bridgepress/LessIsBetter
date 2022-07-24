using Line.Handler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessIsBetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LineParseToListNumber lineParseToListNumber = new LineParseToListNumber(Console.ReadLine());
            lineParseToListNumber.Parse();
            SortBySumOfNumbersInNumber sortBySumOfNumbersInNumber = new SortBySumOfNumbersInNumber(lineParseToListNumber.ListNumbers);
            sortBySumOfNumbersInNumber.Sort();

            foreach (var item in sortBySumOfNumbersInNumber.SortedNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
