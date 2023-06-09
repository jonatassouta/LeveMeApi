﻿using LeveMv.Domain.Entities;
using LeveMv.Domain.Models;

namespace LeveMe.Application.ViewModels
{
    public class ProdutoDto
    {
        public Guid ID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public Guid ClienteId { get; set; }

        public ProdutoDto()
        {

        }
        public Produto ConverterParaEntidade()
        {
            var novoProduto = new Produto();
            novoProduto.ID = !string.IsNullOrEmpty(this.ID.ToString()) ? this.ID : BaseEntity.GenerateId();
            novoProduto.Nome = this.Nome;
            novoProduto.Preco = this.Preco;
            novoProduto.Quantidade = this.Quantidade;
            novoProduto.ClienteId = this.ClienteId;

            return novoProduto;
        }
    }
}
