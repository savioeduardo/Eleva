using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Eleva_WebAPI.Models;

namespace Eleva_WebAPI.Data{
    public class Repository : IRepository {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Escola[]> GetAllEscolasAsync()
        {
            IQueryable<Escola> query = _context.Escolas;

            /*if (includeDisciplina)
            {
                query = query.Include(pe => pe.AlunosDisciplinas)
                             .ThenInclude(ad => ad.Disciplina)
                             .ThenInclude(d => d.Professor);
            }*/

            query = query.AsNoTracking()
                         .OrderBy(c => c.id);

            return await query.ToArrayAsync();
        }

        public async Task<Escola> GetEscolaAsyncById(int escolaId, bool includeTurmas)
        {
            IQueryable<Escola> query = _context.Escolas;

            if (includeTurmas)
            {
                /*query = query.Include(a => a.AlunosDisciplinas)
                             .ThenInclude(ad => ad.Disciplina)
                             .ThenInclude(d => d.Professor);*/
            }

            query = query.AsNoTracking()
                         .OrderBy(escola => escola.id)
                         .Where(escola => escola.id == escolaId);

            return await query.FirstOrDefaultAsync();
        }


        public async Task<Turma[]> GetAllTurmasAsync(bool includeEscola)
        {
            IQueryable<Turma> query = _context.Turmas;

            query = query.Include(e => e.Escola);

            query = query.AsNoTracking()
                         .OrderBy(c => c.id);

            return await query.ToArrayAsync();
        }

        public async Task<Turma[]> GetTurmasByEscolaAsync(int idEscola)
        {
            IQueryable<Turma> query = _context.Turmas;

            query = query.Include(e => e.Escola);

            query = query.AsNoTracking()
                         .OrderBy(c => c.id)
                         .Where(e => e.EscolaId == idEscola);

            return await query.ToArrayAsync();
        }

    }
}