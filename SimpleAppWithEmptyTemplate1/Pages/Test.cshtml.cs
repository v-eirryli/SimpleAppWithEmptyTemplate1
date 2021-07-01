using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleAppWithEmptyTemplate1.Pages
{
    public class TestModel : PageModel
    {
        public void OnGet()
        {
            ViewData["message"] = "Message from the Test model 2";
        }
    }
}
