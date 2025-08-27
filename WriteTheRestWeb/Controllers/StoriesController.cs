using Microsoft.AspNetCore.Mvc;
using WriteTheRestWeb.Models.Story;

public class StoriesController : Controller
{
    private readonly StoriesApiService _storyApiService;

    public StoriesController(StoriesApiService storyApiService)
    {
        _storyApiService = storyApiService;
    }

    public async Task<IActionResult> Index()
    {
        var stories = await _storyApiService.GetAllAsync();
        return View(stories);
    }

    // Details action'ı da Index'e yönlendiriliyor
    public async Task<IActionResult> Details(short id)
    {
        // İsterseniz burada detay verisini TempData ile Index'e gönderebilirsiniz
        return RedirectToAction("Index");
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateStoryDto dto)
    {
        var success = await _storyApiService.AddAsync(dto);
        // Her durumda Index'e yönlendir
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> AdminPanelEdit(short id)
    {
        var story = await _storyApiService.GetByIdAsync(id);
        if (story == null) return NotFound();

        var dto = new UpdateStoryDto
        {
            Id = story.Id,
            Title = story.Title,
            Theme = story.Theme,
            Description = story.Description
        };
        return View("AdminPanelEdit", dto);
    }

    [HttpPost]
    public async Task<IActionResult> AdminPanelEdit(UpdateStoryDto dto)
    {
        var success = await _storyApiService.UpdateAsync(dto);
        // Düzenleme sonrası Index'e yönlendir
        return RedirectToAction("Index");

    }

    [HttpPost]
    public async Task<IActionResult> Delete(short id)
    {
        var success = await _storyApiService.DeleteAsync(id);
        // Her durumda Index'e yönlendir
        return RedirectToAction("Index");
    }
}