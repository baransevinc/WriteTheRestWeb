namespace WriteTheRestWeb.Models.Chapter
{
    public class CreateChapterDto
    {
        public short StoryId { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public string? Summary { get; set; }
    }
}
