using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Handler
{
    public class SortBySumOfNumbersInNumberComparer : IComparer<long>
    {
        public int Compare(long x, long y)
        {
            if (SumNumberInNumber(x) > SumNumberInNumber(y))
            {
                return 1;
            }
            else if (SumNumberInNumber(x) < SumNumberInNumber(y))
            {
                return -1;
            }
            else
            {
                long result = string.Compare(x.ToString(), y.ToString());
                if (result > 0)
                {
                    return 1;
                }
                else if (result < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        private long SumNumberInNumber(long number)
        {
            long sum = 0;
            long newNumber = number;

            for (int i = 0; newNumber != 0; i++)
            {
                sum += newNumber % 10;
                newNumber = newNumber / 10;
            }

            return sum;
        }
    }
}
