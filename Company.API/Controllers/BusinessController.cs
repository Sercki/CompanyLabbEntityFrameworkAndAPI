// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace Company.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BusinessController : ControllerBase
{
	private readonly IDbService _db;
	public BusinessController(IDbService db) => _db = db;

	// GET: api/<BusinessController>
	[HttpGet]
	public async Task<IResult> Get() =>
	await _db.HttpGetAsync<Business, BusinessDTO>();

	// GET api/<BusinessController>/5
	[HttpGet("{id}")]
	public async Task<IResult> Get(int id) =>
	await _db.HttpSingleAsync<Business, BusinessDTO>(id);

	// POST api/<BusinessController>
	[HttpPost]
	public async Task<IResult> Post([FromBody] BusinessDTO business) =>
		await _db.HttpPostAsync<Business, BusinessDTO>(business);

	// PUT api/<BusinessController>/5
	[HttpPut("{id}")]
	public async Task<IResult> Put(int id, [FromBody] BusinessDTO business) =>
		await _db.HttpPutAsync<Business, BusinessDTO>(id, business);

	// DELETE api/<BusinessController>/5
	[HttpDelete("{id}")]
	public async Task<IResult> Delete(int id) =>
		await _db.HttpDeleteAsync<Business>(id);
}


