using Microsoft.AspNetCore.Mvc;
using ViaCepAPI.Integration.Interfaces;
using ViaCepAPI.Integration.Response;

namespace ViaCepAPI.Controllers;

public class ViaCepController : ControllerBase
{
    private readonly IViaCepIntegration _viaCepIntegration;
    public ViaCepController(IViaCepIntegration viaCepIntegration)
    {
        _viaCepIntegration = viaCepIntegration;
    }

    [HttpGet("{cep}")]
    public async Task<ActionResult<ViaCepResponse>> ListarDadosEndereco(string cep)
    {
       var responseData = await _viaCepIntegration.ObterDadosViaCep(cep);

        if (responseData == null)
        {
            return BadRequest("CEP não encontrado!");
        }

        return Ok(responseData);
    }

   
}
