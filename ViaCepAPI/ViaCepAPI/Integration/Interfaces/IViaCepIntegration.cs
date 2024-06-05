using ViaCepAPI.Integration.Response;

namespace ViaCepAPI.Integration.Interfaces;

public interface IViaCepIntegration
{
    Task<ViaCepResponse> ObterDadosViaCep(string cep);
}
