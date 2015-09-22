using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDI.Implementations
{
    public class XMLTransformer
    {
        public void Transform(IEnumerable<string> data, string savePath)
        {
            data.Select(dat =>
            {
                Console.WriteLine(dat + "\n");
                return dat;
            }).ToList();
        }
    }
}
