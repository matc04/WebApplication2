using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Areas.Client.Models
{
    public class ClientWebAddress
    {

        public ClientWeb ClientWeb { get; set; }

        public WebApplication2.Models.Address Address { get; set; }

        public List<WebApplication2.Models.Address> Addresses { get; set; }

    }
}
