namespace YouTubeBlazorApp.Models
{
    public class YouTubeSearchResponse
    {
        public List<Item> Items { get; set; }
        public string NextPageToken { get; set; }
    }

    public class Item
    {
        public Snippet Snippet { get; set; }
        public Id Id { get; set; }
    }

    public class Snippet
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Thumbnails Thumbnails { get; set; }
    }

    public class Id
    {
        public string VideoId { get; set; }
    }

    public class Thumbnails
    {
        public Thumbnail Medium { get; set; }
    }

    public class Thumbnail
    {
        public string Url { get; set; }
    }

}
