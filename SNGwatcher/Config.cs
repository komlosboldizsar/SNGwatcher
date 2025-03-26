using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SNGwatcher
{
    public class Config
    {

        [JsonPropertyName("receiver")]
        public ConfigReceiver Receiver { get; set; }

        [JsonPropertyName("remote")]
        public ConfigRemote Remote { get; set; }

    }
}
