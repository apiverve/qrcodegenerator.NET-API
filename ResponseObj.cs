using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("correction")]
        public string Correction { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("margin")]
        public int Margin { get; set; }

        [JsonProperty("expires")]
        public int Expires { get; set; }

        [JsonProperty("downloadURL")]
        public string DownloadURL { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
