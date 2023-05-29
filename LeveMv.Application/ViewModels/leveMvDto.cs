using LeveMv.Domain.Entities;
using LeveMv.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeveMv.Application.ViewModels
{
    public class leveMvDto
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }

       public leveMvDto()
        {

        }

        public LeMv ConverterParaEntidade()
        {
            var novoLeve = new LeMv();
            novoLeve.ID = !string.IsNullOrEmpty(this.ID.ToString()) ? this.ID : BaseEntity.GenerateId();
            novoLeve.Nome = this.Nome;

            return novoLeve;
        }
    }
}
