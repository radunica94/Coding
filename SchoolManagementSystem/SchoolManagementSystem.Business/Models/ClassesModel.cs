namespace SchoolManagementSystem.Business.Models
{
    public class ClassesModel
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public List<StudentsModel> Students { get; set; } = new List<StudentsModel>();
        public List<SubjectModel> Subject { get; set; } = new List<SubjectModel>();
    }
}
