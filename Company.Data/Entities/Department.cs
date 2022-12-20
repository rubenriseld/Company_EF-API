using Companies.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Companies.Data.Entities;

public class Department : IEntity
{
    public int Id { get; set; }

    [MaxLength(80), Required]
    public string? Name { get; set; }

    public int CompanyId { get; set; } 
    public virtual Company? Company { get; set; }
    public virtual ICollection<Employee>? Employees { get; set; }
}
