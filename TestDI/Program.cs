using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDI
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardReport standardReport = new StandardReport();
            standardReport.Execute();
        }
    }
}
