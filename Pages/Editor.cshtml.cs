using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class EditorModel : PageModel
    {
        public void OnGet()
        {
        }

        public void  OnPost(string editor)
        {
            var html = editor;
        }
    }
}
