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
        private List<int> _listNumbers;
        public List<int> SortedNumbers { get; set; }

        public SortBySumOfNumbersInNumber(List<int> listNumbers)
        {
            _listNumbers = listNumbers;
        }

        public void Sort()
        {
            SortedNumbers = _listNumbers.OrderBy(x => x, new SortBySumOfNumbersInNumberComparer()).ToList();
        }
    }
}
