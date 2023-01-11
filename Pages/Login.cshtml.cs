using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Services;

namespace MyApp.Namespace
{
    
    public class LoginModel : PageModel
    {
        //[BindProperty]
        public string Username { get; set; }
        //[BindProperty]
        public string Password { get; set; }

        public string U { get; set; }
        public string P { get; set; }

        private ILoginService _loginService { get; set; }

        public LoginModel(ILoginService loginService) // DI dependency injection
        {
            _loginService = loginService;
        }

        public IActionResult OnGet()
        {
            //Username = "admin";
            //Password = "password";
            if (_loginService.LoggedIn)
            {
                // RazorPage Dashboard
                return RedirectToPage("Dashboard");//, new { loggedin = "true", username = Username});
            }
            return null;
        }

        public IActionResult OnPost(string Username, string Password) 
        {
            U = Username.ToUpper();
            P = Password.ToUpper();
            var isLoggedIn = _loginService.Login(Username, Password);
            if(isLoggedIn) 
            {
                // RazorPage Dashboard
                return RedirectToPage("Dashboard");//, new { loggedin = "true", username = Username});
            }  
            return Redirect("/Login"); // url / Login
            //Console.WriteLine($"UserName: {Username}, Password: {Password}");
        }
    }
}
