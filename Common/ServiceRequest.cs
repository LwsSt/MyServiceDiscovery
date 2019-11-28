using System.Collections.Generic;

namespace Common
{
    public class ServiceRequest
    {
        public Channel Channel { get; set; }
        public ICollection<string> Scopes { get; set; }
    }
}
