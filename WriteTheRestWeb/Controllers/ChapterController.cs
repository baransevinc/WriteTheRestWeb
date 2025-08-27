using Microsoft.AspNetCore.Mvc;
using WriteTheRestWeb.Models.Chapter;

public class ChapterController : Controller
{
    private readonly ChapterApiService _chapterApiService;

    public ChapterController(ChapterApiService chapterApiService)
    {
        _chapterApiService = chapterApiService;
    }

    public async Task<IActionResult> Index()
    {
        var chapters = await _chapterApiService.GetAllAsync();
        return View(chapters);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(short id)
    {
        var chapter = await _chapterApiService.GetByIdAsync(id);
        if (chapter == null) return NotFound();
        return View(chapter);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(UpdateChapterDto dto)
    {
        var success = await _chapterApiService.UpdateAsync(dto);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateChapterDto dto)
    {
        var success = await _chapterApiService.AddAsync(dto);
        return RedirectToAction("AddChapter", new { storyId = dto.StoryId });
    }

    [HttpPost]
    public async Task<IActionResult> Delete(short id, short storyId)
    {
        var success = await _chapterApiService.DeleteAsync(id);
        return RedirectToAction("AddChapter", new { storyId });
    }

    [HttpGet]
    public async Task<IActionResult> AddChapter(short storyId)
    {
        var chapters = await _chapterApiService.GetAllAsync();
        ViewBag.StoryId = storyId;
        // Eğer sadece ilgili hikayenin bölümlerini göstermek istersen:
        // chapters = chapters.Where(c => c.StoryId == storyId).ToList();
        return View(chapters);
    }
}