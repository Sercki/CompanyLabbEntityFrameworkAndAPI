// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace Company.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PositionController : ControllerBase
{
	private readonly IDbService _db;
	public PositionController(IDbService db) => _db = db;

	// GET: api/<PositionController>
	[HttpGet]
	public async Task<IResult> Get() =>
		await _db.HttpGetAsync<Position, PositionDTO>();

	// GET api/<PositionController>/5
	[HttpGet("{id}")]
	public async Task<IResult> Get(int id) =>
		await _db.HttpSingleAsync<Position, PositionDTO>(id);

	// POST api/<PositionController>
	[HttpPost]
	public async Task<IResult> Post([FromBody] PositionDTO position) =>
		await _db.HttpPostAsync<Position, PositionDTO>(position);

	// PUT api/<PositionController>/5
	[HttpPut("{id}")]
	public async Task<IResult> Put(int id, [FromBody] PositionDTO position) =>
		await _db.HttpPutAsync<Position, PositionDTO>(id, position);

	// DELETE api/<PositionController>/5
	[HttpDelete("{id}")]
	public async Task<IResult> Delete(int id) =>
		await _db.HttpDeleteAsync<Position>(id);
}
