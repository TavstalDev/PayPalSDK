using System.Net;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tavstal.PayPalSDK.Tests.Models;

[DataContract]
public class Resource
{
    [JsonProperty("endpoint")]
    public required string Endpoint { get; set; }
    
    [JsonProperty("statusCode")]
    public required int StatusCode { get; set; }
    
    [JsonIgnore]
    public string? JsonRequest { get; set; }
    
    [JsonIgnore]
    public required string JsonResponse { get; set; }
    
    public HttpResponseMessage Responder(HttpRequestMessage request)
    {
        var path = request.RequestUri?.AbsolutePath ?? string.Empty;
        
        if (path.Contains(AuthResource.Endpoint))
        {
            return new HttpResponseMessage((HttpStatusCode)AuthResource.StatusCode)
            {
                Content = new StringContent(AuthResource.JsonResponse, Encoding.UTF8, "application/json")
            };
        }
        
        if (path.Contains(Endpoint))
        {
            return new HttpResponseMessage((HttpStatusCode)StatusCode)
            {
                Content = new StringContent(JsonResponse, Encoding.UTF8, "application/json")
            };
        }
        return new HttpResponseMessage(HttpStatusCode.NotFound);
    }
    
    public static Resource FromFile(string path)
    {
        string json = File.ReadAllText(path);
        JObject jobject = JObject.Parse(json);
        return new Resource
        {
            Endpoint = jobject["endpoint"]?.ToString() ?? throw new InvalidOperationException("Resource JSON must contain an 'endpoint' property"),
            StatusCode = jobject["statusCode"]?.ToObject<int>() ?? throw new InvalidOperationException("Resource JSON must contain a 'statusCode' property"),
            JsonRequest = jobject["request"]?.ToString(),
            JsonResponse = jobject["response"]?.ToString() ?? throw new InvalidOperationException("Resource JSON must contain a 'response' property")
        };
    }
    
    private static Resource? _authResource;
    public static Resource AuthResource => _authResource ??= FromFile("Resources/authResponse.json");
}