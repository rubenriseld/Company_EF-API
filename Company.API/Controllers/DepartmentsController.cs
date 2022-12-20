using Companies.API.Extensions;
using Companies.Common.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Companies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDbService _db;
        public DepartmentsController(IDbService db) => _db = db;

        // GET: api/<CoursesController>
        [HttpGet]
        public async Task<IResult> Get() =>
            await _db.HttpGetAsync<Department, DepartmentDTO>();

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
            await _db.HttpSingleAsync<Department, DepartmentDTO>(id);

        // POST api/<CoursesController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] DepartmentDTO department) =>
            await _db.HttpPostAsync<Department, DepartmentDTO>(department);

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] DepartmentDTO dto) =>
            await _db.HttpPutAsync<Department, DepartmentDTO>(id, dto);


        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.HttpDeleteAsync<Department>(id);
    }
}
