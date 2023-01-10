namespace WebApp.Services
{
    public interface ILoginService
    {
        public bool LoggedIn { get; }
        public string UserName { get; }
        public bool Login(string username, string password);
    }
}
