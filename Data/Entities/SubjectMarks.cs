namespace WebApplication3.Data.Entities
{
    public class SubjectMarks
    {
        public int Id { get; set; }
        public string? Subject { get; set; }
        public int IntMaxMarks { get; set; }
        public int IntMarks { get; set; }
        public int SemMaxMarks { get; set; }
        public int SemMarks { get; set; }
        public int Total {  get; set; }
    }

}
