using Companies.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Companies.Data.Entities
{
    public class Company : IEntity
    {
        public int Id { get; set; }

        [MaxLength(80), Required]
        public string? Name { get; set; }
        [MaxLength(80), Required]
        public string? OrganisationNumber { get; set; }

        public virtual ICollection<Department>? Departments { get; set; }
    }
}
