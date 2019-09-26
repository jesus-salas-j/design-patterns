using System.Collections.Generic;

namespace design_patters.Adapter
{
    public interface ResourcesService
    {
        IEnumerable<Picture> PicturesOf(string id);
        IEnumerable<Video> VideosOf(string id);
    }
}
