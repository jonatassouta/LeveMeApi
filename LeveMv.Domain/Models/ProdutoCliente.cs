using LeveMv.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeveMe.Domain.Models
{
    public class ProdutoCliente
    {
        public Guid ProdutoId { get; set; }
        public Guid ClienteId { get; set; }

        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
    }
}
