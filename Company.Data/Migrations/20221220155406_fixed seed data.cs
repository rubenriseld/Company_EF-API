using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Companies.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixedseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name", "OrganisationNumber" },
                values: new object[] { 1, "SweCo", "2154516238" });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Developer" },
                    { 2, "Database Administrator" },
                    { 3, "Project Manager" },
                    { 4, "HR Director" },
                    { 5, "CEO" },
                    { 6, "IT Director" },
                    { 7, "Recruiter" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CompanyId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "IT" },
                    { 2, 1, "HR" },
                    { 3, 1, "Management" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "FirstName", "IsUnionMember", "LastName", "Salary" },
                values: new object[,]
                {
                    { 1, 3, "Lars", false, "Andersson", 45000m },
                    { 2, 3, "William", true, "Eklund", 32000m },
                    { 3, 3, "Selma", true, "Wikström", 35000m },
                    { 4, 1, "Adam", false, "Lundin", 31500m },
                    { 5, 1, "Eva", true, "Nyberg", 31000m },
                    { 6, 1, "Johan", true, "Blomqvist", 34000m },
                    { 7, 2, "Anna", true, "Löfgren", 29000m }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTitles",
                columns: new[] { "EmployeeId", "TitleId" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 2, 4 },
                    { 3, 6 },
                    { 4, 1 },
                    { 5, 1 },
                    { 5, 2 },
                    { 6, 1 },
                    { 6, 3 },
                    { 7, 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "EmployeeTitles",
                keyColumns: new[] { "EmployeeId", "TitleId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Titles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
