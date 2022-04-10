namespace SchoolManagementSystem.Business.Models
{
    public class UsersModel
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Role { get; set; }
        public DateTime Birthday { get; set; }
        public string? Apartment { get; set; }
        public string? ZipCode { get; set; }
    }
}
