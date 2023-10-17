using System.Net.Http;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, ILogger log)
{
    var client = new HttpClient();
    var response = await client.PostAsync("https://example.com", new StringContent("Hello, world!"));
    return response;
}
