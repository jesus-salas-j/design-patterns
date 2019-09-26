namespace design_patters.Adapter
{
    public class Picture
    {
        public string Title { get; }
        public string Url { get; }

        public Picture(string title, string url)
        {
            Title = title;
            Url = url;
        }   
    }
}
