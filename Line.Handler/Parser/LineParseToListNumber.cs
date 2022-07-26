using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Handler
{
    public class LineParseToListNumber : IParser
    {
        private string _line;
        public List<long> ListNumbers;

        public LineParseToListNumber(string line)
        {
            ListNumbers = new List<long>();
            _line = line;
        }

        public void Parse()
        {
            string newLine = _line.Trim();
            string[] array = newLine.Split(' ');
            bool isSuccessfully = false;
            long number = 0;

            foreach (string item in array)
            {
                isSuccessfully = long.TryParse(item,out number);
                if (isSuccessfully)
                {
                    ListNumbers.Add(number);
                }
            }
        }
    }
}
