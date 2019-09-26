using System.Collections.Generic;

namespace design_patters.Adapter
{
    public class ResourcesServiceAdapter : MultimediaService
    {
        private readonly ResourcesService resourcesService;

        public ResourcesServiceAdapter(ResourcesService resourcesService)
        {
            this.resourcesService = resourcesService;
        }

        public IEnumerable<IMultimedia> MultimediasOf(long id)
        {
            IEnumerable<Picture> pictures = resourcesService.PicturesOf(id.ToString());
            IEnumerable<Video> videos = resourcesService.VideosOf(id.ToString());

            List<IMultimedia> multimedias = new List<IMultimedia>();
            int order = 0;

            foreach (Picture picture in pictures)
            {
                multimedias.Add(new Multimedia(picture.Title, order++, picture.Url, MultimediaType.Image));                
            }

            foreach (Video video in videos)
            {
                multimedias.Add(new Multimedia(video.Title, order++, video.Url, MultimediaType.Video));
            }

            return multimedias;
        }
    }
}
