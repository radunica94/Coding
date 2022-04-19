namespace SchoolManagementSystem.Business.Models
{
    public class StudentsModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Grade { get; set; }
        public DateTime Birthday { get; set; }
        public string? Gender { get; set; }
        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }

    }
}
