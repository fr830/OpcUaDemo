using System;
using System.Collections.Generic;
using System.Text;
using Opc.Ua;
using Opc.Ua.Server;

namespace OpcUaServerDemo1
{
    public class SimpleNodeManager : CustomNodeManager2
    {
        #region Constructors
        /// <summary>
        /// Initializes the node manager.
        /// </summary>
        protected SimpleNodeManager(
            IServerInternal server,
            params string[] namespaceUris)
        : base(server, (ApplicationConfiguration)null, namespaceUris)
        {
        }

        /// <summary>
        /// Initializes the node manager.
        /// </summary>
        public SimpleNodeManager(
            IServerInternal server,
            ApplicationConfiguration configuration,
            params string[] namespaceUris) : base(server, configuration, namespaceUris)
        {
        }
        #endregion
    }
}
