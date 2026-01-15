namespace EmpTask.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string ImageUrl { get; set; }
        public string ManagerName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
