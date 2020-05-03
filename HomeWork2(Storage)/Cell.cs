using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2_Storage_
{
    public class Cell<T>
    {
        public T Data { get; set; }
        public Cell<T> Next { get; set; }
        public Cell(T inputData)
        {
            Data = inputData;
        }
    }
}
