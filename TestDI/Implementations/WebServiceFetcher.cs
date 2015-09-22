using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDI.Implementations
{
    public class WebServiceFetcher
    {
        public IEnumerable<string> Fetch()
        {
            return new List<string> { "This", "is", "a", "demo" };
        }
    }
}
