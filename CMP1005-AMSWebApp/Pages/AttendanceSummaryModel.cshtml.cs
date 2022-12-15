using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AMSLibrary.Models;

namespace CMP1005_AMSWebApp.Pages
{
    public class AttendanceSummaryModelModel : PageModel
    {
        [BindProperty]
        public Gathering GatheringEvent { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            var urlString = "https://amswebapiservice.azurewebsites.net/";
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(urlString);

            await Task.Delay(0);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await Task.Delay(0);

            return Page();
        }
    }
}
