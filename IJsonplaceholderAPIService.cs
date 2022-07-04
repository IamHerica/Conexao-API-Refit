using Refit;
using System.Threading.Tasks;

namespace ConexaoEntreAPI_Refit
{
    public interface IJsonplaceholderAPIService
    {
        [Get("/todos/{id}")]
        Task<JsonPlaceholderResponse> GetTitle(int id);
    }
}
