namespace EmployeeAPI.Models
{
    public class EmployeeAddress
    {
        public int Id { get; set; }
        public string AddressLine { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
