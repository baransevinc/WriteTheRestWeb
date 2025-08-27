namespace WriteTheRestWeb.Models.Story
{
    public class UpdateStoryDto
    {
        public short Id { get; set; }
        public string Title { get; set; }
        public string Theme { get; set; }
        public string? Description { get; set; }
    }
}
