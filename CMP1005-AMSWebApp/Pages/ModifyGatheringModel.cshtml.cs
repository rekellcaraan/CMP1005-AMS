using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMP1005_AMSWebApp.Models;
using CMP1005_AMSWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CMP1005_AMSApiService.Data;

namespace CMP1005_AMSWebApp.Pages
{
    public class ModifyGatheringModelModel : PageModel
    {
        private readonly AMSWebApiService _amswebapiServce;
        private readonly AMSDBContext _amsdbContext;

        public ModifyGatheringModelModel(AMSWebApiService amswebapiService, AMSDBContext amsdbContext)
        {
            _amswebapiServce = amswebapiService;
            _amsdbContext = amsdbContext;
        }

        [BindProperty]
        public GatheringModel gathering { get; set; } = default!;

        [HttpGet(Guid id)]
        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null || id == Guid.Empty)
            {
                return NotFound();
            }

            var gathering = _amsdbContext.Gatherings.FirstOrDefault(g => g.Id == id);

            return Page();
        }

    }
}
