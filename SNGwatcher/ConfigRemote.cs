using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SNGwatcher
{
    public class ConfigRemote
    {

        [JsonPropertyName("baseUrl")]
        public string BaseURL { get; set; }

        [JsonPropertyName("id")]
        public string ID { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

    }
}
