using Companies.API.Extensions;
using Companies.Common.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Companies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IDbService _db;
        public EmployeesController(IDbService db) => _db = db;

        // GET: api/<CoursesController>
        [HttpGet]
        public async Task<IResult> Get() =>
            await _db.HttpGetAsync<Employee, EmployeeDTO>();

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
            await _db.HttpSingleAsync<Employee, EmployeeDTO>(id);

        // POST api/<CoursesController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] EmployeeDTO employee) =>
            await _db.HttpPostAsync<Employee, EmployeeDTO>(employee);

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] EmployeeDTO dto) =>
            await _db.HttpPutAsync<Employee, EmployeeDTO>(id, dto);


        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.HttpDeleteAsync<Employee>(id);
    }
}
