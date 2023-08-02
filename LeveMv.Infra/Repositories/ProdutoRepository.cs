using LeveMe.Domain.InterfacesRepositories;
using LeveMv.Data.Context;
using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;

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
                atualizado.Quantidade = produto.Quantidade;

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

        public async Task<List<Produto>> ListarPorCliente(Guid id, string? number)
        {
            if (number == "2")
            {
                return await _context.Produtos.Where(c => c.ClienteId == id && c.Quantidade == 0).ToListAsync(); ;
            }
            else if (number == "3")
            {
                return await _context.Produtos.Where(c => c.ClienteId == id && c.Quantidade > 0).ToListAsync(); ;
            }

            var result = await _context.Produtos.Where(c => c.ClienteId == id)
                .ToListAsync();

            return result;
        }

        public async Task<Produto> PesquisarPoId(Guid produtoId)
        {
            return await _context.Produtos.FirstOrDefaultAsync(x => x.ID.Equals(produtoId));
        }

        public async Task<List<Produto>> ListarPorNome(string nome)
        {
            return await _context.Produtos.Where(l => l.Nome.StartsWith(nome)).ToListAsync();
        }

        public async Task<string> Vender(Guid produtoId, int quantidade)
        {
            var produto = await PesquisarPoId(produtoId);
            var msg = "";

            if (produto.Quantidade >= quantidade)
            {
                produto.Quantidade = produto.Quantidade - quantidade;
                await Atualizar(produto);

                msg = "Estoque Atualizado!";
                msg = JsonConvert.SerializeObject(msg);
                return msg;
            }
            else
            {
                msg = "A quantidade tem que ser menor ou igual ao estoque do produto!";
                msg = JsonConvert.SerializeObject(msg);
                return msg;
            }

        }
    }
}
