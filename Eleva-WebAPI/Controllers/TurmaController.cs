using System;
using Microsoft.AspNetCore.Mvc;
using Eleva_WebAPI.Data;
using System.Threading.Tasks;
using Eleva_WebAPI.Models;

namespace Eleva_WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TurmaController : ControllerBase{
        private readonly IRepository _repo;
        public TurmaController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get(){
            try{
                var result = await _repo.GetAllTurmasAsync(false);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Erro {ex.Message}");
            }
        }

        [HttpGet("escola/{escolaId}")]
        public async Task<IActionResult> GetTurmasByEscola(int escolaId){
            try{
                var result = await _repo.GetTurmasByEscolaAsync(escolaId);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Erro {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> post(Turma model){
            try{
                _repo.Add(model);
                if(await _repo.SaveChangesAsync()){

                    return Ok(model);
                }
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Erro {ex.Message}");
            }
            return BadRequest();
        }

        [HttpPut("{turmaId}")]
        public async Task<IActionResult> put(int turmaId, Turma model)
        {
            try
            {
                var turma = await _repo.GetTurmaAsyncById(turmaId);
                if(turma == null) return NotFound();

                _repo.Update(model);

                if(await _repo.SaveChangesAsync())
                {
                    return Ok(model);
                }                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

        [HttpDelete("{turmaId}")]
        public async Task<IActionResult> delete(int turmaId)
        {
            try
            {
                var turma = await _repo.GetTurmaAsyncById(turmaId);
                if(turma == null) return NotFound();
                _repo.Delete(turma);

                if(await _repo.SaveChangesAsync())
                {
                    return Ok(new {message = "Turma deletada" });
                }                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }

            return BadRequest();
        }

    
    }

}