using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Delegates_
{
    class AlphaNumbericCollector : ICollector
    {
        public List<string> numbericStringsCollector { get; private set; } = new List<string>();
       
        private bool Validate(string inputString)
        {
            return inputString.Any(symbol => char.IsDigit(symbol));
        }
        public void Save(string inputString)
        {
            if (Validate(inputString))
            {
                numbericStringsCollector.Add(inputString);
            }
        }
        public List<string> GetSaved()
        {
            return new List<string>(numbericStringsCollector);
        }
        public IEnumerator<string> GetEnumerator()
        {
            return numbericStringsCollector.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
