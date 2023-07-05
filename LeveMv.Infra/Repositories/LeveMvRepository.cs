using LeveMv.Data.Context;
using LeveMv.Domain.InterfacesRepositories;
using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace LeveMv.Data.Repositories
{
    public class LeveMvRepository : ILeveMeRepository
    {
        private readonly LeveMeContext _context;

        public LeveMvRepository(LeveMeContext context) 
        {
            _context = context;
        }

        public async Task Atualizar(Domain.Models.Levemv leveMv)
        {
            var atualizado = await Pesquisar(leveMv.ID);
            if (leveMv != null && !string.IsNullOrEmpty(leveMv.ID.ToString()) && leveMv.ID.Equals(leveMv.ID))
            {
                atualizado.Nome = leveMv.Nome;

                _context.LeveMvs.Update(atualizado);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Cadastar(Domain.Models.Levemv leveMv)
        {
            await _context.LeveMvs.AddAsync(leveMv);
            await _context.SaveChangesAsync();
        }

        public async Task<string> Excluir(Guid leveMvId)
        {
            var leveMv = await Pesquisar(leveMvId);
            if (leveMv != null && !string.IsNullOrEmpty(leveMv.ID.ToString()) && leveMv.ID.Equals(leveMvId))
            {
                _context.LeveMvs.Remove(leveMv);
                await _context.SaveChangesAsync();
                return "Excluido com sucesso";
            }else
            {
                return "Registro Não Encontrado!";
            }
        }

        public async Task<List<Domain.Models.Levemv>> Listar()
        {
            return await _context.LeveMvs.ToListAsync();
        }

        public async Task<List<Levemv>> ListarPorCliente()
        {
            var result = await _context.LeveMvs
                .Include(c => c.Clientes)
                .ToListAsync();

            foreach (var item in result)
            {
                foreach (var subitem in item.Clientes)
                {
                    subitem.Cliente = _context.Clientes.FirstOrDefault(c => c.ID.Equals(subitem.ClienteId));
                }
            }

            return result;
        }

        public async Task<List<Domain.Models.Levemv>> ListarPorNome(string nome)
        {
            return await _context.LeveMvs.Where(l => l.Nome.StartsWith(nome)).ToListAsync();
        }

        public async Task<Domain.Models.Levemv> Pesquisar(Guid leveMvId)
        {
            return await _context.LeveMvs.FirstOrDefaultAsync(x => x.ID.Equals(leveMvId));
        }
    }
}
