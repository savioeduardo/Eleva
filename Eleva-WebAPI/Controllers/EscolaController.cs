using System;
using Microsoft.AspNetCore.Mvc;
using Eleva_WebAPI.Data;
using System.Threading.Tasks;
using Eleva_WebAPI.Models;

namespace Eleva_WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EscolaController : ControllerBase{
        private readonly IRepository _repo;
        public EscolaController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get(){
            try{
                var result = await _repo.GetAllEscolasAsync();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Erro {ex.Message}");
            }
        }

        [HttpGet("{escolaId}")]
        public async Task<IActionResult> GetByEscolaId(int escolaId){
            try{
                var result = await _repo.GetEscolaAsyncById(escolaId, false);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Erro {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> post(Escola model){
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

        [HttpPut("{escolaId}")]
        public async Task<IActionResult> put(int escolaId, Escola model)
        {
            try
            {
                var escola = await _repo.GetEscolaAsyncById(escolaId, false);
                if(escola == null) return NotFound();

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

        [HttpDelete("{escolaId}")]
        public async Task<IActionResult> delete(int escolaId)
        {
            try
            {
                var escola = await _repo.GetEscolaAsyncById(escolaId, false);
                if(escola == null) return NotFound();
                _repo.Delete(escola);

                if(await _repo.SaveChangesAsync())
                {
                    return Ok(new {message = "Escola deletada" });
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