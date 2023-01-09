using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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

        public void OnGet()
        {
            //Username = "admin";
            //Password = "password";
        }

        public void OnPost(string Username, string Password) 
        {
            U = Username.ToUpper();
            P = Password.ToUpper();
            //Redirect("/Login");
            RedirectToPage("Login");
            //this.Username = "koukou";
            //this.Password = "koukou";
            //Console.WriteLine($"UserName: {Username}, Password: {Password}");
        }
    }
}
