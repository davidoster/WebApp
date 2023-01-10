namespace WebApp.Services
{
    public class LoginService : ILoginService
    {
        public bool LoggedIn { get; private set; }

        public string UserName { get; private set; }

        public LoginService()
        {
            UserName = "NONAME";
        }
        public bool Login(string username, string password)
        {
            if(username == "admin" &&  password == "admin")
            {
                LoggedIn = true;
                UserName = username;
                return true;
            }
            return false;
        }
    }
}
