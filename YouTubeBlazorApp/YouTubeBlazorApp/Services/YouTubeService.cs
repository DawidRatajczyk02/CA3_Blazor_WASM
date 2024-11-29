using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using YouTubeBlazorApp.Models;

namespace YouTubeBlazorApp.Services
{
    public class YouTubeService
    {
        private readonly HttpClient _httpClient;
        private const string ApiKey = "AIzaSyC3k9SVlXWoIVIZIy2AMvuKKLbjSY6038M";
        private const string BaseUrl = "https://www.googleapis.com/youtube/v3/";

        public YouTubeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<YouTubeSearchResponse> SearchVideosAsync(string query, string? pageToken = null)
        {
            var url = $"{BaseUrl}search?part=snippet&q={query}&type=video&maxResults=6&key={ApiKey}";

            if (!string.IsNullOrEmpty(pageToken))
            {
                url += $"&pageToken={pageToken}";
            }

            return await _httpClient.GetFromJsonAsync<YouTubeSearchResponse>(url)
                   ?? new YouTubeSearchResponse();
        }


        public async Task<YouTubeVideoDetailsResponse> GetVideoDetailsAsync(string videoId)
        {
            var url = $"{BaseUrl}videos?part=snippet&id={videoId}&key={ApiKey}";
            return await _httpClient.GetFromJsonAsync<YouTubeVideoDetailsResponse>(url)
                ?? new YouTubeVideoDetailsResponse();
        }
    }
}