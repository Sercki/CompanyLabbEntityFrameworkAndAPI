// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace Company.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PersonnelPositionController : ControllerBase
	{
		private readonly IDbService _db;
		public PersonnelPositionController(IDbService db) => _db = db;

		[HttpPost]
		public async Task<IResult> Post([FromBody] PersonnelPositionDTO personnelPosition) =>
			await _db.HttpAddAsync<PersonnelPosition, PersonnelPositionDTO>(personnelPosition);

		[HttpDelete]
		public async Task<IResult> Delete(PersonnelPositionDTO dto) =>
			await _db.HttpDeleteAsync<PersonnelPosition, PersonnelPositionDTO>(dto);
	}
}
