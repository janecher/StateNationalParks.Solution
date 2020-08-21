using System.Threading.Tasks;
using RestSharp;

namespace StateNationalParks.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall()
    {
      RestClient client = new RestClient("https://developer.nps.gov/api/v1/parks");
      RestRequest request = new RestRequest($"?api_key={EnvironmentVariables.ApiKey}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}