using WriteTheRestWeb.Models.Story;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WriteTheRestWeb.Models;

public class StoriesApiService
{
    private readonly HttpClient _httpClient;

    public StoriesApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Tüm hikayeleri getir
    public async Task<List<StoryDto>> GetAllAsync()
    {
        var response = await _httpClient.GetAsync("api/stories/getall");
        response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<Result<List<StoryDto>>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        return result.Data;
    }

    // Id ile hikaye getir
    public async Task<StoryDto> GetByIdAsync(short id)
    {
        var response = await _httpClient.GetAsync($"api/stories?id={id}");
        response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<Result<StoryDto>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        return result.Data;
    }

    // Yeni hikaye ekle
    public async Task<bool> AddAsync(CreateStoryDto dto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/stories/add", dto);
        return response.IsSuccessStatusCode;
    }

    // Hikaye güncelle
    public async Task<bool> UpdateAsync(UpdateStoryDto dto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/stories/update", dto);
        return response.IsSuccessStatusCode;
    }

    // Hikaye sil
    public async Task<bool> DeleteAsync(short id)
    {
        var response = await _httpClient.DeleteAsync($"api/stories/delete?id={id}");
        return response.IsSuccessStatusCode;
    }
}
