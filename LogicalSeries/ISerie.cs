using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSeries
{
    public interface ISerie<T>
    {
        T GenerateNext();
        string Name { get; }
    }
}
