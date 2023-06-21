using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeveMv.Domain.Models
{
    public class ClienteLeveMe
    {
        public Guid ClienteId { get; set; }
        public Guid LeveMeId { get; set; }

        public Leveme LeveMe { get; set; }
        public Cliente Cliente { get; set; }
    }
}
