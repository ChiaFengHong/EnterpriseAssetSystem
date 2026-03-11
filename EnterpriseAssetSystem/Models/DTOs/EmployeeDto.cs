namespace EnterpriseAssetSystem.Models.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        public string EmployeeNumber { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}
