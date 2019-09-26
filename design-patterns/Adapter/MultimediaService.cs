using System.Collections.Generic;

namespace design_patters.Adapter
{
    public interface MultimediaService
    {
        IEnumerable<IMultimedia> MultimediasOf(long id);
    }
}
