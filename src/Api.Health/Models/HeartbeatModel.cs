using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AarekhLabs.AspNetCore.Api.Health.Models
{
    public class HeartbeatModel
    {
        public HeartbeatModel()
        {
            Heartbeat = "OK";
        }

        [JsonProperty(propertyName:"heartbeat")]
        public string Heartbeat { get; private set; }
    }
}
