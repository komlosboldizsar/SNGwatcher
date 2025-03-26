using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SNGwatcher
{
    public class ReceiverRX8200 : IReceiver
    {

        public string Type => "Ericcson RX8200";

        public class Factory : IReceiverFactory
        {
            public string Code => "rx8200";

            public IReceiver CreateInstance(ConfigReceiver configReceiver)
                => new ReceiverRX8200(configReceiver);
        }

        public ReceiverRX8200(ConfigReceiver configReceiver)
            => _myConfig = configReceiver;

        private readonly ConfigReceiver _myConfig;

        public async Task<ReceiverData> ReadStatusAsync()
        {
            string url = $"http://{_myConfig.Address}/jsonActions";
            RequestPartGet[] parts = new RequestPartGet[]
            {
                new("input.sat.cnMargin")
            };
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(url, parts);
            ReceiverData returnValue = new()
            {
                Timestamp = DateTime.Now,
                ReadSuccess = response.IsSuccessStatusCode
            };
            if (response.IsSuccessStatusCode)
            {
                ResponsePart[] responseParts = await response.Content.ReadFromJsonAsync<ResponsePart[]>();
                if ((responseParts.Length > 0) && (responseParts[0].Value is int cnMargin))
                    returnValue.CnMargin = cnMargin;
            }
            StatusUpdate?.Invoke(this, returnValue);
            return returnValue;            
        }

        private class RequestPartGet
        {

            [JsonPropertyName("action")]
            public string Action => "get";

            [JsonPropertyName("uid")]
            public string Uid { get; private init; }

            public RequestPartGet(string uid)
                => Uid = uid;

        }

        private class ResponsePart
        {

            [JsonPropertyName("status")]
            public string Status { get; set; }

            [JsonPropertyName("value")]
            public object Value { get; set; }

        }

        private readonly HttpClient _httpClient = new();

        public event ReceiverStatusUpdateDelegate StatusUpdate;

    }
}
