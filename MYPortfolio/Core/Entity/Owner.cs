using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Owner : EntityBase
    {
        public string fullName { get; set; }
        public string profile { get; set; }
        public string Avatar { get; set; }

        public Address Address { get; set; }
    }
}
