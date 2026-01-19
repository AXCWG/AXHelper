using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AXHelper.Helpers;

public class WebHelper<T>
{
    class JsonSerializer
    {
        
    }
    private HttpClient _http;
    public WebHelper(HttpClient httpClient)
    {
        _http = httpClient;
    }

    public async Task<HttpResponseMessage> SendAsync<T>(T send, string uri)
    {
        return await _http.PostAsync(uri, JsonContent.Create("send"));
    }
    
}