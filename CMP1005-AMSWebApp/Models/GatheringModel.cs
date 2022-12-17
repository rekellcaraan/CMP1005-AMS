using System;
using AMSLibrary.Models;
namespace CMP1005_AMSWebApp.Models;

public class GatheringModel: Gathering
{
    public string Delivery { get; set; } = default!;

    public string Remarks { get; set; } = default!;
}

