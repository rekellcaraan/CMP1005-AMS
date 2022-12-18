using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AMSLibrary.Models;
using CMP1005_AMSWebApp.Models;
using CMP1005_AMSWebApp.Services;

namespace CMP1005_AMSWebApp.Pages
{
    public class AttendanceSummaryModelModel : PageModel
    {
        private readonly AMSWebApiService _amswebapiServce;

        public AttendanceSummaryModelModel(AMSWebApiService amswebapiService)
        {
            _amswebapiServce = amswebapiService;
        }

        [BindProperty]
        public List<GatheringModel> AvailableGatherings { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync()
        {
            AvailableGatherings = await _amswebapiServce.GetAvailableGatherings();

            return Page();
        }
    }
}
