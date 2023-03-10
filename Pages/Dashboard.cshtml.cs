using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Services;

namespace WebApp.Pages
{
    [Authorize]
    public class DashboardModel : PageModel
    {
        public string Username { get; set; }
        public string Message { get; set; }

        public bool LoggedIn { 
            get
            {
                return _loginService.LoggedIn;
            } 
        }

        private ILoginService _loginService { get; set; }
        public DashboardModel(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public void OnGet()
        {
            if (_loginService.LoggedIn) 
            {
                Username = _loginService.UserName;
                Message = $"Welcome {Username}";
            }
            else
            {
                Username = null;
                Message = $"Not allowed page!";
            }
        }
        public IActionResult OnPost(string old, string password1, string password2)
        {
            if(_loginService.ChangePassword(old, password1, password2))
            {
                Message = "Successfully changed password!";
                return RedirectToPage();
            }
            Message = "The password wasn't changed! Try again!!!";
            return RedirectToPage();
        }
    }
}
