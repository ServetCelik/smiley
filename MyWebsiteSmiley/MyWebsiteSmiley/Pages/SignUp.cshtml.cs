using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyWebsiteSmiley.Models;
using LogicLayer;
using System.ComponentModel.DataAnnotations;

namespace MyWebsiteSmiley.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string FirstName { get; set; }
        LogicClass logicClass = new LogicClass();
        
        [BindProperty]
        public Admin user { get; set; }

        
        public void OnGet()
        {
            
        }
        public IActionResult OnPostAsync()
        {
            if (ModelState.IsValid == false)
            {


                return Page();
                
            }
            else
            {   //this method feeds a list inside login class with admin accounts. Normally i should do this once a open website not every login attempt. It will be changed
                logicClass.updateAdmins();
                if (logicClass.CheckUserExistence(user.UserName, user.Email)) //check if this username or email exist. If not,then add the user to database.
                {
                    logicClass.AddUser("admin", user.UserName, user.Password, user.Email);

                    return RedirectToPage("/Index");
                }
                
                return Page();
            }
            
        }
        
    }
}
