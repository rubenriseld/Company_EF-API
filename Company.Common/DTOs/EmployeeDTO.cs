namespace Companies.Common.DTOs;

public record EmployeeDTO
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int DepartmentId { get; set; }
    public bool? IsUnionMember { get; set; }
    public decimal? Salary { get; set; }
}
