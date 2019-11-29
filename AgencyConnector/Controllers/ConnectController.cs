using Common;
using Microsoft.AspNetCore.Mvc;

namespace AgencyConnector.Controllers
{
    [Route("[controller]")]
    public class ConnectController : ControllerBase
    {
        [HttpPost]
        public ActionResult<ServiceResponse> Connect(ServiceRequest request)
        {
            return new ServiceResponse()
            {
                Connector = "This response is from Agency Connector",
                Response = request.Data
            };
        }
    }
}
