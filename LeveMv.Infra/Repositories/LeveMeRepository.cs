using LeveMv.Data.Context;
using LeveMv.Domain.InterfacesRepositories;
using LeveMv.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LeveMv.Data.Repositories
{
    public class LeveMeRepository : ILeveMeRepository
    {
        private readonly LeveMeContext _context;

        public LeveMeRepository(LeveMeContext context) 
        {
            _context = context;
        }

        public async Task Atualizar(Leveme leveMv)
        {
            var atualizado = await Pesquisar(leveMv.ID);
            if (leveMv != null && !string.IsNullOrEmpty(leveMv.ID.ToString()) && leveMv.ID.Equals(leveMv.ID))
            {
                atualizado.Nome = leveMv.Nome;

                _context.LeveMes.Update(atualizado);
            }
        }

        public async Task Cadastar(Leveme leveMv)
        {
            await _context.LeveMes.AddAsync(leveMv);
            await _context.SaveChangesAsync();
        }

        public async Task Excluir(Guid leveMvId)
        {
            var leveMv = await Pesquisar(leveMvId);
            if (leveMv != null && !string.IsNullOrEmpty(leveMv.ID.ToString()) && leveMv.ID.Equals(leveMvId))
                await _context.LeveMes.ExecuteDeleteAsync();
        }

        public async Task<List<Leveme>> Listar()
        {
            return await _context.LeveMes.ToListAsync();
        }

        public async Task<List<Leveme>> ListarPorCliente()
        {
            var result = await _context.LeveMes
                .Include(c => c.Clientes)
                .ToListAsync();

            return result;
        }

        public async Task<Leveme> Pesquisar(Guid leveMvId)
        {
            return await _context.LeveMes.FirstOrDefaultAsync(x => x.ID.Equals(leveMvId));
        }
    }
}
