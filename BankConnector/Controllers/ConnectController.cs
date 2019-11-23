using Common;
using Microsoft.AspNetCore.Mvc;

namespace BankConnector.Controllers
{
    [Route("[controller]")]
    public class ConnectController : ControllerBase
    {
        [HttpPost]
        public ActionResult<ServiceResponse> Connect(ServiceRequest request)
        {
            return new ServiceResponse()
            {
                Id = 1,
                Item = string.Join(' ', request.Scopes)
            };
        }
    }
}
