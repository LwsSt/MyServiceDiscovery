using System.Collections.Generic;

namespace Common
{
    public class ServiceRequest
    {
        public string Channel { get; set; }
        public ICollection<string> Scopes { get; set; }
    }
}
