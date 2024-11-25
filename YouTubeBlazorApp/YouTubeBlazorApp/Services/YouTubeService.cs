using System.Net.Http.Json;
using YouTubeBlazorApp.Models;

using YouTubeBlazorApp.Models;

namespace YouTubeBlazorApp.Services
{
    public class YouTubeService
    {
        private readonly HttpClient _httpClient;
        private const string ApiKey = "AIzaSyC3k9SVlXWoIVIZIy2AMvuKKLbjSY6038M";

        public YouTubeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<YouTubeSearchResponse> SearchVideosAsync(string query)
        {
            var url = $"search?part=snippet&q={query}&type=video&key={ApiKey}";
            return await _httpClient.GetFromJsonAsync<YouTubeSearchResponse>(url);
        }
    }
}
