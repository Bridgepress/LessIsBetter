using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Handler
{
    public class LessIsBetter
    {
        public string Order(string input)
        {
            LineParseToListNumber lineParseToListNumber = new LineParseToListNumber(input);
            lineParseToListNumber.Parse();
            SortBySumOfNumbersInNumber sortBySumOfNumbersInNumber = new SortBySumOfNumbersInNumber(lineParseToListNumber.ListNumbers);
            sortBySumOfNumbersInNumber.Sort();

            return string.Join(" ", sortBySumOfNumbersInNumber.SortedNumbers);
        }
    }
}
