namespace design_patters.Adapter
{
    public interface IMultimedia
    {
        string Title();
        int Order();
        string Url();
        MultimediaType Type();
    }
}
