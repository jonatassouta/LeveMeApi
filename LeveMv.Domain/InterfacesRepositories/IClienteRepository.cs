using LeveMv.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeveMe.Domain.InterfacesRepositories
{
    public interface IClienteRepository
    {
        Task Cadastar(Cliente cliente);
        Task Atualizar(Cliente cliente);
        Task<List<Cliente>> Listar();
        Task<List<Cliente>> ListarPorNome(string nome);
        Task Excluir(Guid clienteId);
        Task<Cliente> PesquisarPoId(Guid clienteId);
    }
}
