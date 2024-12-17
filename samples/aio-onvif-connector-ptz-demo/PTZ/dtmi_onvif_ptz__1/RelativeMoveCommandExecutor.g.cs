/* Code generated by Azure.Iot.Operations.ProtocolCompiler; DO NOT EDIT. */

#nullable enable

namespace PTZ.dtmi_onvif_ptz__1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using Azure.Iot.Operations.Protocol;
    using Azure.Iot.Operations.Protocol.RPC;
    using Azure.Iot.Operations.Protocol.Models;
    using PTZ;

    public static partial class Ptz
    {
        /// <summary>
        /// Specializes a <c>CommandExecutor</c> class for Command 'RelativeMove'.
        /// </summary>
        public class RelativeMoveCommandExecutor : CommandExecutor<RelativeMoveRequestPayload, EmptyJson>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="RelativeMoveCommandExecutor"/> class.
            /// </summary>
            internal RelativeMoveCommandExecutor(IMqttPubSubClient mqttClient)
                : base(mqttClient, "RelativeMove", new Utf8JsonSerializer())
            {
            }
        }
    }
}