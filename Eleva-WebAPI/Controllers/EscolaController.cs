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
            return Ok("Teste");
            /*try{
                var result = await _repo.GetAllAlunosAsync(false);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return BadRequest($"Erro {ex.Message}");
            }*/
        }

    
    }

}