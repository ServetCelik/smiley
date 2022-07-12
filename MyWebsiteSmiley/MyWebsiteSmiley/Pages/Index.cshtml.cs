using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyWebsiteSmiley.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsiteSmiley.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string username { get; set; } = "Servet";


        public List<PostModel> Posts { get; set; } = new List<PostModel>();   

        

        public void OnGet()
        {   //I use some dummy data here. I could use database as well but i have some issues with uploading photos. Thats because i didnt want to add a table in my sqlserver. It will be added later.
            Posts.Add(new PostModel("Programmers, everyday", "images/programmer.PNG", DateTime.Now));
            Posts.Add(new PostModel("If ramen noodles can’t fix it, don’t mention it.", "images/mechanic.PNG", DateTime.Now));
            Posts.Add(new PostModel("I like broccoli and sports. Go sports!", "images/brocoli.PNG", DateTime.Now));
            Posts.Add(new PostModel("OMG!","images/car.PNG", DateTime.Now));

        }
    }
}
