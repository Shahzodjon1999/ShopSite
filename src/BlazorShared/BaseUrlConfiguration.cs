namespace BlazorShared;

public class BaseUrlConfiguration
{
    public const string CONFIG_NAME = "https://localhost:5001/";

    public string ApiBase { get; set; }
    public string WebBase { get; set; }
}
