using Companies.API.Extensions;
using Companies.Common.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Companies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesTitlesController : ControllerBase
    {
        private readonly IDbService _db;
        public EmployeesTitlesController(IDbService db) => _db = db;

        [HttpPost]
        public async Task<IResult> Post([FromBody] EmployeeTitleDTO employeeTitle) =>
            await _db.HttpAddAsync<EmployeeTitle, EmployeeTitleDTO>(employeeTitle);

        [HttpDelete]
        public async Task<IResult> Delete(EmployeeTitleDTO dto) =>
            await _db.HttpDeleteAsync<EmployeeTitle, EmployeeTitleDTO>(dto);
    }
}
