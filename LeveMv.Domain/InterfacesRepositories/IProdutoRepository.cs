﻿using LeveMv.Domain.Models;

namespace LeveMe.Domain.InterfacesRepositories
{
    public interface IProdutoRepository
    {
        Task Cadastar(Produto produto);
        Task Atualizar(Produto produto);
        Task<string> Vender(Guid produtoId, int quantidade);
        Task<List<Produto>> Listar();
        Task<List<Produto>> ListarPorNome(string nome);
        Task<List<Produto>> ListarPorCliente(Guid id, string? number);
        Task Excluir(Guid produtoId);
        Task<Produto> PesquisarPoId(Guid produtoId);
    }
}
