using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeveMv.Domain.Models
{
    public class ClienteLeveMv
    {
        public Guid ClienteId { get; set; }
        public Guid LeveMvId { get; set; }

        public Levemv LeveMv { get; set; }
        public Cliente Cliente { get; set; }
    }
}
