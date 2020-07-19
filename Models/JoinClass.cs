using Areas.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class JoinClass
    {
        public ClientSearchModel ClientSearchModel { get; set; }

        public List<ClientWeb> Clients { get; set; }

    }
}
