using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDI.Implementations
{
    public class WebServerPublisher
    {
        public void Publish(string localSavePath, string webServerPath)
        {
            Console.WriteLine("Uploaded from " + localSavePath + " to " + webServerPath);
        }
    }
}
