using Model.DTOs;
using System.Text.Json;

namespace TappBlazor.Services;

public class TakenService
{
    private readonly HttpClient _httpClient;

    public TakenService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ICollection<TaakDTO>> GetAllTakenDTOByProjectIdAsync(int projectID)
    {
        var taakAPIString = await _httpClient.GetStringAsync($"api/taak/{projectID}");

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

        return JsonSerializer.Deserialize<ICollection<TaakDTO>>(taakAPIString, options)!;
    }
}