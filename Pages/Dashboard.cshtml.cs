using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Services;

namespace WebApp.Pages
{
    public class DashboardModel : PageModel
    {
        private bool _loggedin;
        public string Username { get; set; }
        public string Message { get; set; }

        private ILoginService _loginService { get; set; }
        public DashboardModel(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public void OnGet()
        {
            if (_loginService.LoggedIn) 
            {
                _loggedin = true;
                Username = _loginService.UserName;
                Message = $"Welcome {Username}";
            }
            else
            {
                _loggedin = false;
                Username = null;
                Message = $"Not allowed page!";
            }
        }
    }
}
