using System.Net.Http;

namespace ArbeitNowApi
{
    public class ArbeitNow
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://www.arbeitnow.com/api";
        public ArbeitNow()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetJobBoard()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/job-board-api");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
