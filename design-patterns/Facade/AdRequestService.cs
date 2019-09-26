namespace design_patters.Facade
{
    public interface AdRequestService
    {
        void CreateAdRequest(AdRequest adRequest, User user);
        void RefuseAdRequest(AdRequest adRequest, User user);
    }
}
