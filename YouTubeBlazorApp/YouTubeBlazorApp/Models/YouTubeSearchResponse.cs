namespace YouTubeBlazorApp.Models
{
    // Pagination information
    public class PageInfo
    {
        public int TotalResults { get; set; }
        public int ResultsPerPage { get; set; }
    }

    // Main response model for YouTube Search API
    public class YouTubeSearchResponse
    {
        public string? Kind { get; set; }
        public string? Etag { get; set; }
        public string? PrevPageToken { get; set; }
        public string? NextPageToken { get; set; }
        public List<SearchItem>? Items { get; set; }

        public class PageInfo
        {
            public int TotalResults { get; set; }
            public int ResultsPerPage { get; set; }
        }

        public class SearchItem
        {
            public Id? Id { get; set; }
            public Snippet? Snippet { get; set; }
        }

        public class Id
        {
            public string? Kind { get; set; }
            public string? VideoId { get; set; }
        }

        public class Snippet
        {
            public string? PublishedAt { get; set; }
            public string? ChannelId { get; set; }
            public string? Title { get; set; }
            public string? Description { get; set; }
            public Thumbnails? Thumbnails { get; set; }
            public string? ChannelTitle { get; set; }
            public string? LiveBroadcastContent { get; set; }
        }

        public class Thumbnails
        {
            public ThumbnailInfo? Default { get; set; }
            public ThumbnailInfo? Medium { get; set; }
            public ThumbnailInfo? High { get; set; }

            public class ThumbnailInfo
            {
                public string? Url { get; set; }
                public int? Width { get; set; }
                public int? Height { get; set; }
            }
        }
    }
}