using System;
namespace CMP1005_AMSWebApp.Services;

public class AMSWebApiService
{
	private Uri amsBaseUrl = new Uri("https://localhost:7136/ams");
	static readonly HttpClient amsHttpClient = new HttpClient();

	public AMSWebApiService()
	{
	}
}

