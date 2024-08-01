using Cod3rsGrowth.Dominio.Filtros;
using Cod3rsGrowth.Dominio.Modelos;
using Cod3rsGrowth.Servico.ServicoBaralho;
using Microsoft.AspNetCore.Mvc;

namespace Cod3rsGrowth.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaralhoController : ControllerBase
    {
        private readonly BaralhoServico _baralhoServico;

        public BaralhoController(BaralhoServico baralhoServico)
        {
            _baralhoServico = baralhoServico;
        }

        [HttpPost]
        public CreatedResult Criar([FromBody] Baralho baralho)
        {
            baralho.Id = _baralhoServico.Criar(baralho);
            return Created("Baralho criado com sucesso!", baralho);
        }

        [HttpGet]
        public OkObjectResult ObterTodos([FromQuery] BaralhoFiltro filtro)
        {
            var baralhos = _baralhoServico.ObterTodos(filtro);
            return Ok(baralhos);
        }

        [HttpGet("{id}")]
        public OkObjectResult ObterPorId([FromRoute] int id)
        {
            var baralho = _baralhoServico.ObterPorId(id);
            return Ok(baralho);
        }

        [HttpPatch]
        public NoContentResult Atualizar([FromBody] Baralho baralho)
        {
            _baralhoServico.Atualizar(baralho);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public NoContentResult Excluir([FromRoute] int id)
        {
            _baralhoServico.Excluir(id);
            return NoContent();
        }
    }
}