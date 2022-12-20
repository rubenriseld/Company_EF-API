using Companies.API.Extensions;
using Companies.Common.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Companies.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompaniesController : ControllerBase
{
    private readonly IDbService _db;
    public CompaniesController(IDbService db) => _db = db;

    // GET: api/<CoursesController>
    [HttpGet]
    public async Task<IResult> Get() =>
        await _db.HttpGetAsync<Company, CompanyDTO>();

    // GET api/<CoursesController>/5
    [HttpGet("{id}")]
    public async Task<IResult> Get(int id) =>
        await _db.HttpSingleAsync<Company, CompanyDTO>(id);

    // POST api/<CoursesController>
    [HttpPost]
    public async Task<IResult> Post([FromBody] CompanyDTO company) =>
        await _db.HttpPostAsync<Company, CompanyDTO>(company);

    // PUT api/<CoursesController>/5
    [HttpPut("{id}")]
    public async Task<IResult> Put(int id, [FromBody] CompanyDTO dto) =>
        await _db.HttpPutAsync<Company, CompanyDTO>(id, dto);


    // DELETE api/<CoursesController>/5
    [HttpDelete("{id}")]
    public async Task<IResult> Delete(int id) =>
        await _db.HttpDeleteAsync<Company>(id);
}
