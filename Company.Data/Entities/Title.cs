using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities;

public class Title : IEntity
{
    public int Id { get; set; }

    [MaxLength(80), Required]
    public string? Name { get; set; }
    public virtual ICollection<Employee>? Employees { get; set; }
}
