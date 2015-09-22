using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDI.Implementations;

namespace TestDI
{
    public class StandardReport
    {
        private readonly WebServiceFetcher _webServiceFetcher;
        private readonly XMLTransformer _xmlTransformer;
        private readonly WebServerPublisher _webServerPublisher;

        public StandardReport()
        {
            _webServiceFetcher = new WebServiceFetcher();
            _xmlTransformer = new XMLTransformer();
            _webServerPublisher = new WebServerPublisher();
        }

        public void Execute()
        {
            const string localSavePath = @"C:\reports\DemoReport.xml";
            const string webServerPath = @"Server\DemoReport.xml";
            var data = _webServiceFetcher.Fetch();
            _xmlTransformer.Transform(data: data, savePath: localSavePath);
            _webServerPublisher.Publish(localSavePath: localSavePath, webServerPath: webServerPath);
            Console.ReadKey();
        }
    }
}
