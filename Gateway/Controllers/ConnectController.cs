using Common;
using Microsoft.AspNetCore.Mvc;

namespace Gateway.Controllers
{
    [Route("[controller]")]
    public class ConnectController : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> Connect(ServiceRequest request)
        {
            return NoContent();
        }
    }
}
