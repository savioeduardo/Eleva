using System.Threading.Tasks;
using Eleva_WebAPI.Models;

namespace Eleva_WebAPI.Data{
    public interface IRepository{
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //ESCOLAS
        Task<Escola[]> GetAllEscolasAsync();  
        Task<Escola> GetEscolaAsyncById(int escolaId, bool includeTurmas);

        //TURMAS
        Task<Turma[]> GetAllTurmasAsync(bool includeEscola); 
        Task<Turma[]> GetTurmasByEscolaAsync(int escolaId);  
    }
}