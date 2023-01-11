namespace WebApp.Services
{
    public class LoginService : ILoginService
    {
        private string _password { get; set; }
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
                _password = password;
                return true;
            }
            return false;
        }

        public bool ChangePassword(string currentPassword, string newPassword, string newPassword1)
        {
            if(currentPassword == _password && newPassword == newPassword1)
            {
                _password = newPassword; 
                return true;
            }
            return false;
        }
    }
}
