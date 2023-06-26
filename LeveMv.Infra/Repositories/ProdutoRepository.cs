using LeveMe.Domain.InterfacesRepositories;
using LeveMv.Data.Context;
using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LeveMe.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly LeveMeContext _context;

        public ProdutoRepository(LeveMeContext context)
        {
            _context = context;
        }

        public async Task Atualizar(Produto produto)
        {
            var atualizado = await PesquisarPoId(produto.ID);
            if (produto != null && !string.IsNullOrEmpty(produto.ID.ToString()) && produto.ID.Equals(produto.ID))
            {
                atualizado.Nome = produto.Nome;
                atualizado.Preco = produto.Preco;

                _context.Produtos.Update(atualizado);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Cadastar(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();
        }

        public async Task Excluir(Guid produtoId)
        {
            var produto = await PesquisarPoId(produtoId);
            if (produto != null && !string.IsNullOrEmpty(produto.ID.ToString()) && produto.ID.Equals(produtoId))
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Produto>> Listar()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<List<Produto>> ListarPorCliente()
        {
            throw new NotImplementedException();
        }

        public async Task<Produto> PesquisarPoId(Guid produtoId)
        {
             return await _context.Produtos.FirstOrDefaultAsync(x => x.ID.Equals(produtoId));
        }
    }
}
