using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AMSLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CMP1005_AMSWebApp.Models;
using CMP1005_AMSWebApp.Services;

namespace CMP1005_AMSWebApp.Pages
{
    public class NewGatheringModelModel : PageModel
    {
        private readonly AMSWebApiService _amswebapiServce;

        public NewGatheringModelModel(AMSWebApiService amswebapiService)
        {
            _amswebapiServce = amswebapiService;
        }

        [BindProperty]
        public GatheringModel newGathering { get; set; } = default!;

        public void OnPost()
        {
            _amswebapiServce.CreateNewGathering(newGathering);
        }

    }
}
