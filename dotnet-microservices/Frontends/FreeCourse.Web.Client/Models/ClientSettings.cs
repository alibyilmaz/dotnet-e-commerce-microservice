using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace FreeCourse.Web.Client.Models
{
    public class ClientSettings
    {
        public Client WebMvcClient { get; set; }
        public Client WebMvcClientForUser { get; set; }
    }

    public class Client
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}
