using Refit;
using ViaCepAPI.Integration.Response;

namespace ViaCepAPI.Integration.Refit;

public interface IViaCepRefit
{
    [Get("/ws/{cep}/json")]
    Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
}
