namespace WriteTheRestWeb.Models.Story
{
    public class StoryDto
    {
        public short Id { get; set; }
        public string Title { get; set; }
        public string Theme { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsPublished { get; set; }
        public DateTime? PublishedAt { get; set; }
        public int ChapterCount { get; set; } // Koleksiyon yerine sayısı
    }
}
