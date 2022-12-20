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

    private void SeedData(ModelBuilder builder)
    {
        var companies = new List<Company>
        {
            new Company{
                Id = 1,
                Name = "SweCo",
                OrganisationNumber = "2154516238"
            }
        };
        builder.Entity<Company>().HasData(companies);

        var departments = new List<Department>
        {
            new Department
            {
                Id = 1,
                Name = "IT",
                CompanyId = 1
            },
            new Department
            {
                Id = 2,
                Name = "HR",
                CompanyId = 1
            },
            new Department
            {
                Id = 3,
                Name = "Management",
                CompanyId = 1
            }
        };
        builder.Entity<Department>().HasData(departments);

        var employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                FirstName = "Lars",
                LastName = "Andersson",
                DepartmentId = 3,
                IsUnionMember = false,
                Salary = 45000
            },
            new Employee
            {
                Id = 2,
                FirstName = "William",
                LastName = "Eklund",
                DepartmentId = 3,
                IsUnionMember = true,
                Salary = 32000
            },
            new Employee
            {
                Id = 3,
                FirstName = "Selma",
                LastName = "Wikström",
                DepartmentId = 3,
                IsUnionMember = true,
                Salary = 35000
            },
            new Employee
            {
                Id = 4,
                FirstName = "Adam",
                LastName = "Lundin",
                DepartmentId = 1,
                IsUnionMember = false,
                Salary = 31500
            },
            new Employee
            {
                Id = 5,
                FirstName = "Eva",
                LastName = "Nyberg",
                DepartmentId = 1,
                IsUnionMember = true,
                Salary = 31000
            },
            new Employee
            {
                Id = 6,
                FirstName = "Johan",
                LastName = "Blomqvist",
                DepartmentId = 1,
                IsUnionMember = true,
                Salary = 34000
            },
            new Employee
            {
                Id = 7,
                FirstName = "Anna",
                LastName = "Löfgren",
                DepartmentId = 2,
                IsUnionMember = true,
                Salary = 29000
            }
        };
        builder.Entity<Employee>().HasData(employees);

        var titles = new List<Title>
        {
            new Title { Id = 1, Name = "Developer" },
            new Title { Id = 2, Name = "Database Administrator" },
            new Title { Id = 3, Name = "Project Manager" },
            new Title { Id = 4, Name = "HR Director" },
            new Title { Id = 5, Name = "CEO" },
            new Title { Id = 6, Name = "IT Director" },
            new Title { Id = 7, Name = "Recruiter" }
        };
        builder.Entity<Title>().HasData(titles);

        var employeeTitles = new List<EmployeeTitle>
        {
            new EmployeeTitle{ EmployeeId = 1, TitleId = 5 },
            new EmployeeTitle{ EmployeeId = 2, TitleId = 4 },
            new EmployeeTitle{ EmployeeId = 3, TitleId = 6 },
            new EmployeeTitle{ EmployeeId = 4, TitleId = 1 },
            new EmployeeTitle{ EmployeeId = 5, TitleId = 1 },
            new EmployeeTitle{ EmployeeId = 5, TitleId = 2 },
            new EmployeeTitle{ EmployeeId = 6, TitleId = 1 },
            new EmployeeTitle{ EmployeeId = 6, TitleId = 3 },
            new EmployeeTitle{ EmployeeId = 7, TitleId = 7 },
        };
        builder.Entity<EmployeeTitle>().HasData(employeeTitles);
    }
}
