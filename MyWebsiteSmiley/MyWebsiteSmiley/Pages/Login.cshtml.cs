using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebsiteSmiley.Models;
using LogicLayer;

namespace MyWebsiteSmiley.Pages
{
    public class LoginModel : PageModel
    {
        LogicClass logicClass= new LogicClass();

        [BindProperty]
        public string username { get; set; } = "";
        [BindProperty]
        public string password { get; set; } = "";
        [BindProperty]
        public Admin user { get; set; }


        public void OnGet()
        {
            password = "Alice";
        }
        public IActionResult OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                //this method feeds a list inside login class with admin accounts. Normally i should do this once a open website not every login attempt. It will be changed
                logicClass.updateAdmins();
                if (logicClass.LoginCheck(user.UserName, user.Password))
                {
                    // if login is succesfully done, index page open. Otherwise the same page reload
                    return RedirectToPage("/Index");
                }
                
                return Page();
            }
            else
            {
                
                return Page();
            }
        }
    }
}
