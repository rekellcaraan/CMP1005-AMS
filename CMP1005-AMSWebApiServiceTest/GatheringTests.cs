namespace CMP1005_AMSWebApiServiceTest;
using CMP1005_AMSApiService.Controllers;
using CMP1005_AMSApiService.Data;
using Microsoft.EntityFrameworkCore;
using AMSLibrary.Models;

[TestClass]
public class GatheringTests
{
    [TestMethod]
    public void WhenGettingAllAvailableGatherings_ThenListAllCreatedAvailableGatherings()
    {
        using(var amssqllite = new AMSSQLLite()) {

            var controller = new GatheringController(amssqllite.Context);
            var gatheringsList = controller.GetAllAvailableGatherings();

        }
    }
}

