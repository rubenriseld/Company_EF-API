using Companies.API.Extensions;
using Companies.Common.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Companies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitlesController : ControllerBase
    {
        private readonly IDbService _db;
        public TitlesController(IDbService db) => _db = db;

        // GET: api/<CoursesController>
        [HttpGet]
        public async Task<IResult> Get() =>
            await _db.HttpGetAsync<Title, TitleDTO>();

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public async Task<IResult> Get(int id) =>
            await _db.HttpSingleAsync<Title, TitleDTO>(id);

        // POST api/<CoursesController>
        [HttpPost]
        public async Task<IResult> Post([FromBody] TitleDTO title) =>
            await _db.HttpPostAsync<Title, TitleDTO>(title);

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public async Task<IResult> Put(int id, [FromBody] TitleDTO dto) =>
            await _db.HttpPutAsync<Title, TitleDTO>(id, dto);


        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id) =>
            await _db.HttpDeleteAsync<Title>(id);
    }

}
