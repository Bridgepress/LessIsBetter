using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Handler
{
    public class SortBySumOfNumbersInNumber 
    {
        private List<long> _listNumbers;
        public List<long> SortedNumbers { get; set; }

        public SortBySumOfNumbersInNumber(List<long> listNumbers)
        {
            _listNumbers = listNumbers;
        }

        public void Sort()
        {
            SortedNumbers = _listNumbers.OrderBy(x => x, new SortBySumOfNumbersInNumberComparer()).ToList();
        }
    }
}
