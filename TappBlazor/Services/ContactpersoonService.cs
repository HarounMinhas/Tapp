using Model.DTOs;
using System.Text.Json;

namespace TappBlazor.Services;

public class ContactpersoonService
{
    private readonly HttpClient _httpClient;

    public ContactpersoonService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ICollection<ContactPersoonDTO>> GetAllContactpersonenDTOAsync()
    {
        var contactpersoonAPIString = await _httpClient.GetStringAsync("api/contactpersoon");

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        };

        return JsonSerializer.Deserialize<ICollection<ContactPersoonDTO>>(contactpersoonAPIString, options)!;
    }
}
