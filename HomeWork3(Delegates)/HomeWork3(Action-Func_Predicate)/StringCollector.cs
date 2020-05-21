using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Delegates_
{
    public delegate void InitiateSC(string someString);
    //Згадані вище класи повинні зберігати стрічки в списку(накопичувати їх).
    class StringCollector : ICollector
    {
        private List<string> stringCollector { get; set; } = new List<string>();
        private bool Validate(string inputString)
        {
            return inputString.All(symbol => !char.IsDigit(symbol));            
        }
        public void Save(string inputString)
        {
            if (Validate(inputString))
            {
                stringCollector.Add(inputString);
            }
        }
        public List<string> GetSaved()
        {
            return new List<string>(stringCollector);
        }
        public IEnumerator<string> GetEnumerator()
        {
            return stringCollector.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
