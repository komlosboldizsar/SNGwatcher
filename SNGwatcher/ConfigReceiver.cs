using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SNGwatcher
{
    public class ConfigReceiver
    {

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

    }
}
