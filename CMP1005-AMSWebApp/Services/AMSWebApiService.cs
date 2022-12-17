using System;
using CMP1005_AMSWebApp.Models;
using Newtonsoft.Json;

namespace CMP1005_AMSWebApp.Services;

public class AMSWebApiService
{
	private string amsBaseUrlString = "https://localhost:7136/ams";
	static readonly HttpClient amsHttpClient = new HttpClient();

	public AMSWebApiService()
	{
	}

	public async Task<List<GatheringModel>> GetAvailableGatherings()
	{

        List<GatheringModel> availableGatherings = new List<GatheringModel>();

        try
        {

            using (HttpResponseMessage response = await amsHttpClient.GetAsync(String.Join('/', amsBaseUrlString, "gathering")))
            {
                response.EnsureSuccessStatusCode();
                string? responseBody = await response.Content.ReadAsStringAsync()!;

                if (!String.IsNullOrEmpty(responseBody))
                { availableGatherings = JsonConvert.DeserializeObject<List<GatheringModel>>(responseBody); }

            }

        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("\nException Caught!");
            Console.WriteLine("Message :{0} ", e.Message);
        }

        return availableGatherings!;
    }
}

