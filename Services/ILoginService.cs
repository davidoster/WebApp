namespace WebApp.Services
{
    public interface ILoginService
    {
        public bool LoggedIn { get; }
        public string UserName { get; }
        public bool Login(string username, string password);
        public bool ChangePassword(string currentPassword, string newPassword, string newPassword1);
    }
}
