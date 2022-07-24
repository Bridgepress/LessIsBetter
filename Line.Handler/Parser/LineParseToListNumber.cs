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
        public List<int> ListNumbers;

        public LineParseToListNumber(string line)
        {
            ListNumbers = new List<int>();
            _line = line;
        }

        public void Parse()
        {
            string newLine = _line.Trim();
            string[] array = newLine.Split(' ');

            foreach (string item in array)
            {
                int number = int.Parse(item);
                ListNumbers.Add(number);
            }
        }
    }
}
