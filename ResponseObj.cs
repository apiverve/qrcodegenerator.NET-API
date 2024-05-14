using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("type")]
    public string type { get; set; }

    [JsonProperty("correction")]
    public string correction { get; set; }

    [JsonProperty("size")]
    public int size { get; set; }

    [JsonProperty("margin")]
    public int margin { get; set; }

    [JsonProperty("base64Image")]
    public string base64Image { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
