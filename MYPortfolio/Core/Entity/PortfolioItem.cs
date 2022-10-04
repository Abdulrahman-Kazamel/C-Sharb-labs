using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class PortfolioItem : EntityBase
    {
        public string projectName { get; set; }
        public string Decription { get; set; }
        public string ImageUrl { get; set; }
    }
}
