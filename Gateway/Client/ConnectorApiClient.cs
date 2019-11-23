using System.Net.Http;
using System.Threading.Tasks;

namespace Common.Client
{
    public class ConnectorApiClient
    {
        private readonly HttpClient client;

        public ConnectorApiClient(HttpClient client)
        {
            this.client = client;
        }

        public async Task<ServiceResponse> Connect(ServiceRequest request)
        {
            var response = await client.PostAsJsonAsync("connect", request);

            return await response.Content.ReadAsAsync<ServiceResponse>();
        }
    }
}
