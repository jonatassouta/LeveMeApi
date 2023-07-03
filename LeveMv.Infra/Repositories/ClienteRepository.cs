using LeveMe.Domain.InterfacesRepositories;
using LeveMv.Data.Context;
using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LeveMe.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly LeveMeContext _context;

        public ClienteRepository(LeveMeContext context)
        {
            _context = context;
        }
        public async Task Atualizar(Cliente cliente)
        {
            var atualizado = await PesquisarPoId(cliente.ID);
            if (cliente != null && !string.IsNullOrEmpty(cliente.ID.ToString()) && cliente.ID.Equals(cliente.ID))
            {
                atualizado.Nome = cliente.Nome;
                atualizado.CNPJ = cliente.CNPJ;
                atualizado.Endereço = cliente.Endereço;
                atualizado.Bairro = cliente.Bairro;
                atualizado.Cidade = cliente.Cidade;
                atualizado.UF = cliente.UF;
                atualizado.Telefone = cliente.Telefone;
                atualizado.Email = atualizado.Email;
                atualizado.Ativo = true;

                _context.Clientes.Update(atualizado);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Cadastar(Cliente cliente)
        {
            cliente.Ativo = true;
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task Excluir(Guid clienteId)
        {
            var cliente = await PesquisarPoId(clienteId);
            if (cliente != null && !string.IsNullOrEmpty(cliente.ID.ToString()) && cliente.ID.Equals(clienteId))
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Cliente>> Listar()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> PesquisarPoId(Guid clienteId)
        {
            return await _context.Clientes.FirstOrDefaultAsync(x => x.ID.Equals(clienteId));
        }

        public async Task<List<Cliente>> ListarPorNome(string nome)
        {
            return await _context.Clientes.Where(l => l.Nome.StartsWith(nome)).ToListAsync();
        }
    }
}
