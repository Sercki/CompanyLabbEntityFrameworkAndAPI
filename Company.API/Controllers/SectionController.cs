// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace Company.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SectionController : ControllerBase
{
	private readonly IDbService _db;
	public SectionController(IDbService db) => _db = db;

	// GET: api/<SectionController>
	[HttpGet]
	public async Task<IResult> Get() =>
		await _db.HttpGetAsync<Section, SectionDTO>();

	// GET api/<SectionController>/5
	[HttpGet("{id}")]
	public async Task<IResult> Get(int id) =>
		await _db.HttpSingleAsync<Section, SectionDTO>(id);

	// POST api/<SectionController>
	[HttpPost]
	public async Task<IResult> Post([FromBody] SectionDTO position) =>
		await _db.HttpPostAsync<Section, SectionDTO>(position);

	// PUT api/<SectionController>/5
	[HttpPut("{id}")]
	public async Task<IResult> Put(int id, [FromBody] SectionDTO position) =>
		await _db.HttpPutAsync<Section, SectionDTO>(id, position);

	// DELETE api/<SectionController>/5
	[HttpDelete("{id}")]
	public async Task<IResult> Delete(int id) =>
		await _db.HttpDeleteAsync<Section>(id);
}
