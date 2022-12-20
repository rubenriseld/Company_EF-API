using Companies.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Data.Contexts;

public class CompanyContext : DbContext
{
    public DbSet<Company> Companies => Set<Company>();
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Employee>  Employees => Set<Employee>();
    public DbSet<Title> Titles => Set<Title>();
    public DbSet<EmployeeTitle> EmployeeTitles => Set<EmployeeTitle>();
    public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
    {


    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<EmployeeTitle>().HasKey(et => new { et.EmployeeId, et.TitleId });
    }
}
