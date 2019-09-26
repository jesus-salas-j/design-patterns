namespace design_patters.Adapter
{
    public class Video
    {
        public string Title { get; set; }
        public string Url { get; set; }

        public Video(string title, string url)
        {
            Title = title;
            Url = url;
        }
    }
}
