using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMSLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CMP1005_AMSWebApp.Pages
{
    public class NewGatheringModelModel : PageModel
    {
        [BindProperty]
        public Gathering GatheringEvent { get; set; } = default!;

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }

    }
}
