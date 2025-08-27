namespace WriteTheRestWeb.Models.Chapter
{
    public class UpdateChapterDto
    {
        public short Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public bool IsCompleted { get; set; }
        public string? Summary { get; set; }
    }
}
