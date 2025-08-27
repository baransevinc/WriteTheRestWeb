using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WriteTheRestWeb.Models;
using WriteTheRestWeb.Models.Chapter;

public class ChapterApiService
{
    private readonly HttpClient _httpClient;

    public ChapterApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Tüm bölümleri getir
    public async Task<List<ChapterDto>> GetAllAsync()
    {
        var response = await _httpClient.GetAsync("api/chapters/getall");
        response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<Result<List<ChapterDto>>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        return result.Data;
    }

    // Id ile bölüm getir
    public async Task<ChapterDto> GetByIdAsync(short id)
    {
        var response = await _httpClient.GetAsync($"api/chapters?id={id}");
        response.EnsureSuccessStatusCode();
        var json = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<Result<ChapterDto>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        return result.Data;
    }

    // Yeni bölüm ekle
    public async Task<bool> AddAsync(CreateChapterDto dto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/chapters/add", dto);
        return response.IsSuccessStatusCode;
    }

    // Bölüm güncelle
    public async Task<bool> UpdateAsync(UpdateChapterDto dto)
    {
        var response = await _httpClient.PostAsJsonAsync("api/chapters/update", dto);
        return response.IsSuccessStatusCode;
    }

    // Bölüm sil
    public async Task<bool> DeleteAsync(short id)
    {
        var response = await _httpClient.DeleteAsync($"api/chapters/delete?id={id}");
        return response.IsSuccessStatusCode;
    }
}
