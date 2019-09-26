namespace design_patters.Facade
{
    public interface AntispamService
    {
        bool IsSpam(string email);
        void StoreAsSpam(string email);
    }
}
