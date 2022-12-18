// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace Company.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonnelController : ControllerBase
{
	private readonly IDbService _db;
	public PersonnelController(IDbService db) => _db = db;

	// GET: api/<PersonnelController>
	[HttpGet]
	public async Task<IResult> Get() =>
		await _db.HttpGetAsync<Personnel, PersonnelDTO>();

	// GET api/<PersonnelController>/5
	[HttpGet("{id}")]
	public async Task<IResult> Get(int id) =>
		await _db.HttpSingleAsync<Personnel, PersonnelDTO>(id);

	// POST api/<PersonnelController>
	[HttpPost]
	public async Task<IResult> Post([FromBody] PersonnelDTO personnel) =>
		await _db.HttpPostAsync<Personnel, PersonnelDTO>(personnel);

	// PUT api/<PersonnelController>/5
	[HttpPut("{id}")]
	public async Task<IResult> Put(int id, [FromBody] PersonnelDTO personnel) =>
		await _db.HttpPutAsync<Personnel, PersonnelDTO>(id, personnel);

	// DELETE api/<PersonnelController>/5
	[HttpDelete("{id}")]
	public async Task<IResult> Delete(int id) =>
		await _db.HttpDeleteAsync<Personnel>(id);
}
