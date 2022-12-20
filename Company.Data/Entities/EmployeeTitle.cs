using Companies.Data.Interfaces;

namespace Companies.Data.Entities;

public class EmployeeTitle : IReferenceEntity
{
    public int EmployeeId { get; set; }
    public int TitleId { get; set; }
    public virtual Employee? Employee { get; set; }
    public virtual Title? Title { get; set; }
}
