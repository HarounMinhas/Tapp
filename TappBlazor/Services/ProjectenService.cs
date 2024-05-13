using Model.DTOs;
using System.Text.Json;
using System.Threading.Tasks;

namespace TappBlazor.Services;

public class ProjectenService
{
    private readonly HttpClient _httpClient;

    public ProjectenService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }


    public async Task<ICollection<ProjectDTO>> GetAllProjectenDTOAsync()
    {
        var projectAPIString = await _httpClient.GetStringAsync("api/project");

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

        return JsonSerializer.Deserialize<ICollection<ProjectDTO>>(projectAPIString, options)!;
        
    }
}
