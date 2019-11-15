using Common;
using Microsoft.AspNetCore.Mvc;

namespace BankConnector.Controllers
{
    [Route("[controller]")]
    public class ConnectController : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> Connect(ServiceRequest request)
        {
            return "Banking";
        }
    }
}
