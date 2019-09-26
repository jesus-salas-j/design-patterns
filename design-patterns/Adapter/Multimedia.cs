namespace design_patters.Adapter
{
    public class Multimedia : IMultimedia
    {
        private readonly string title;
        private readonly int order;
        private readonly string url;
        private readonly MultimediaType type;

        public Multimedia(string title, int order, string url, MultimediaType type)
        {
            this.title = title;
            this.order = order;
            this.url = url;
            this.type = type;
        }

        public string Title()
        {
            return title;
        }

        public int Order()
        {
            return order;
        }

        public string Url()
        {
            return url;
        }

        public MultimediaType Type()
        {
            return type;
        }
    }
}
