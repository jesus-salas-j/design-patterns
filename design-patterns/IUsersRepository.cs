namespace design_patters
{
    public interface IUsersRepository
    {
        bool Exists(string username);
        void Save(User user);
    }
}