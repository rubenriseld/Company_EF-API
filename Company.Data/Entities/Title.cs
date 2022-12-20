using Companies.Data.Interfaces;
using System.ComponentModel.DataAnnotations;


namespace Companies.Data.Entities;

public class Title : IEntity
{
    public int Id { get; set; }

    [MaxLength(80), Required]
    public string? Name { get; set; }
    public virtual ICollection<Employee>? Employees { get; set; }
}
