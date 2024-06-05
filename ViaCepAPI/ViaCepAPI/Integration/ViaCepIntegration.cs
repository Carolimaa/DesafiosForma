using ViaCepAPI.Integration.Interfaces;
using ViaCepAPI.Integration.Refit;
using ViaCepAPI.Integration.Response;

namespace ViaCepAPI.Integration;

public class ViaCepIntegration : IViaCepIntegration
{
    private readonly IViaCepRefit _viaCepRefit;
    public ViaCepIntegration(IViaCepRefit viaCepRefit)
    {
        _viaCepRefit = viaCepRefit;
    }
    public async Task<ViaCepResponse> ObterDadosViaCep(string cep)
    {
       var responseData =  await _viaCepRefit.ObterDadosViaCep(cep);

        if(responseData != null && responseData.IsSuccessStatusCode)
        {
            return responseData.Content;
        }

        return null;
    }
}
