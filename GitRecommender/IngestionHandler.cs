using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GitRecommender
{
	public class IngestionHandler
	{
		public IngestionHandler()
		{
		}

		public async Task StarScraper(string username)
		{

			using (HttpClient client = new())
			{
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				string apiUrl = $"https://api.github.com/{username}/starred";

				HttpResponseMessage response = await client.GetAsync(apiUrl);

				if(response.IsSuccessStatusCode)
				{
					string responseBody = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(responseBody);

					
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }

		}
		// retrive stars per repo
		public async Task StarCounter(string repo)
		{

		}
          
	}
}

