using Microsoft.AspNetCore.Mvc;
using Cod3rsGrowth.Dominio.Modelos.Enums;

[ApiController]
[Route("api/[controller]")]
public class FormatoDeJogoController : ControllerBase
{
    [HttpGet]
    public ActionResult<Dictionary<int, string>> Get()
    {
        var chavesEDescricaoEnum = DescricaoEnum.ObterDescricaoEnum<FormatoDeJogoEnum>();
        return Ok(chavesEDescricaoEnum);
    }
}