using LeveMv.Domain.Entities;
using LeveMv.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeveMv.Application.ViewModels
{
    public class leveMeDto
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }

       public leveMeDto()
        {

        }

        public Domain.Models.Levemv ConverterParaEntidade()
        {
            var novoLeve = new Domain.Models.Levemv();
            novoLeve.ID = !string.IsNullOrEmpty(this.ID.ToString()) ? this.ID : BaseEntity.GenerateId();
            novoLeve.Nome = this.Nome;

            return novoLeve;
        }
    }
}
