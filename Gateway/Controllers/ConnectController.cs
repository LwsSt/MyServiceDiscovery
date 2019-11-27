using Common;
using Common.Client;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Gateway.Controllers
{
    [Route("[controller]")]
    public class ConnectController : ControllerBase
    {
        private readonly ConnectorApiClient client;

        public ConnectController(ConnectorApiClient client)
        {
            this.client = client;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse>> Connect(ServiceRequest request)
        {
            var response = await client.Connect(request);
            return response;
        }
    }
}
