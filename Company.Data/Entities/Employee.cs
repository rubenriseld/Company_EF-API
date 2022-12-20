using Companies.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Companies.Data.Entities;

public class Employee : IEntity
{
    public int Id { get; set; }

    [MaxLength(80), Required]
    public string? FirstName { get; set; }

    [MaxLength(80), Required]
    public string? LastName { get; set; }

    public int DepartmentId { get; set; }
    public virtual Department? Department { get; set; }
    public bool? IsUnionMember { get; set; }

    [Precision(18, 2)]
    public decimal? Salary { get; set; }
    public virtual ICollection<Title>? Titles { get; set; }
}
