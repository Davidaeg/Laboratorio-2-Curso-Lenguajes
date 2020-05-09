using Newtonsoft.Json;


public class JsonMailResponse
{

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("did_you_mean")]
    public string DidYouMean { get; set; }

    [JsonProperty("user")]
    public string User { get; set; }

    [JsonProperty("domain")]
    public string Domain { get; set; }

    [JsonProperty("format_valid")]
    public bool FormatValid { get; set; }

    [JsonProperty("mx_found")]
    public bool MxFound { get; set; }

    [JsonProperty("smtp_check")]
    public bool SmtpCheck { get; set; }

    [JsonProperty("catch_all")]
    public bool CatchAll { get; set; }

    [JsonProperty("role")]
    public bool Role { get; set; }

    [JsonProperty("disposable")]
    public bool Disposable { get; set; }

    [JsonProperty("free")]
    public bool Free { get; set; }

    [JsonProperty("score")]
    public double Score { get; set; }

}

