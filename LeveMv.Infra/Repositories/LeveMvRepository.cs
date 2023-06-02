using LeveMv.Data.Context;
using LeveMv.Domain.InterfacesRepositories;
using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LeveMv.Data.Repositories
{
    public class LeveMvRepository : ILeveMvRepository
    {
        private readonly LeveMvContext _context;

        public LeveMvRepository(LeveMvContext context) 
        {
            _context = context;
        }

        public async Task Atualizar(LeveMe leveMv)
        {
            var atualizado = await Pesquisar(leveMv.ID);
            if (leveMv != null && !string.IsNullOrEmpty(leveMv.ID.ToString()) && leveMv.ID.Equals(leveMv.ID))
            {
                atualizado.Nome = leveMv.Nome;

                _context.LeveMvs.Update(atualizado);
            }
        }

        public async Task Cadastar(LeveMe leveMv)
        {
            await _context.LeveMvs.AddAsync(leveMv);
            await _context.SaveChangesAsync();
        }

        public async Task Excluir(Guid leveMvId)
        {
            var leveMv = await Pesquisar(leveMvId);
            if (leveMv != null && !string.IsNullOrEmpty(leveMv.ID.ToString()) && leveMv.ID.Equals(leveMvId))
                await _context.LeveMvs.ExecuteDeleteAsync();
        }

        public async Task<List<LeveMe>> Listar()
        {
            return await _context.LeveMvs.ToListAsync();
        }

        public async Task<List<LeveMe>> ListarPorCliente()
        {
            var result = await _context.LeveMvs
                .Include(c => c.Clientes)
                .ToListAsync();

            return result;
        }

        public async Task<LeveMe> Pesquisar(Guid leveMvId)
        {
            return await _context.LeveMvs.FirstOrDefaultAsync(x => x.ID.Equals(leveMvId));
        }
    }
}
