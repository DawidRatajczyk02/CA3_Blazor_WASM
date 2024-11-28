namespace YouTubeBlazorApp.Models
{
    public class YouTubeVideoDetailsResponse
    {
        public string? Kind { get; set; }
        public string? Etag { get; set; }
        public List<VideoDetailsItem>? Items { get; set; }

        public class VideoDetailsItem
        {
            public string? Id { get; set; }
            public Snippet? Snippet { get; set; }
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
            public string? CategoryId { get; set; }
        }

        public class Thumbnails
        {
            public ThumbnailInfo? Default { get; set; }
            public ThumbnailInfo? Medium { get; set; }
            public ThumbnailInfo? High { get; set; }
            public ThumbnailInfo? Standard { get; set; }
            public ThumbnailInfo? Maxres { get; set; }

            public class ThumbnailInfo
            {
                public string? Url { get; set; }
                public int? Width { get; set; }
                public int? Height { get; set; }
            }
        }
    }
}
