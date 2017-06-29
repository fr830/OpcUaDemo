using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Opc.Ua;
using Opc.Ua.Server;

namespace OpcUaServerDemo1
{
    public class DemoServer1 : StandardServer
    {
        public IList<Uri> ServerUris
        {
            get { return BaseAddresses.Select(x => x.Url).ToArray(); }
        }
    }
}
