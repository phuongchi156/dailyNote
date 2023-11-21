namespace noteAPI.Model
{
    public class NoteModel
    {
        public string Name { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public DateTime Time { get; set; }
        public int Status { get; set; } = 0;
    }
}
