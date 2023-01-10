using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class DashboardModel : PageModel
    {
        private bool _loggedin;
        public string Username { get; set; }
        public string Message { get; set; }
        public void OnGet(bool? loggedin, string username)
        {
            if (loggedin == true) 
            {
                _loggedin = true;
                Username = username;
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
