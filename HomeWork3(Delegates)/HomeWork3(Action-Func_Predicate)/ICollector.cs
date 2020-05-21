using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_Delegates_
{
    public interface ICollector : IEnumerable<string>
    {
        void Save(string str);
        List<string> GetSaved();
    }
}
