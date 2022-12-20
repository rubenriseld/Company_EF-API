using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities;

public class EmployeeTitle : IReferenceEntity
{
    public int EmployeeId { get; set; }
    public int TitleId { get; set; }
    public virtual Employee? Employee { get; set; }
    public virtual Title? Title { get; set; }
}
