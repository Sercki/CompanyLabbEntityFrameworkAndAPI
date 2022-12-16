using Company.Common.DTOs;
using Company.Data.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CompanyContext>(
options =>
options.UseSqlServer(
builder.Configuration.GetConnectionString("CompanyConnection")));

ConfigureAutoMapper(builder.Services);
RegisterServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void ConfigureAutoMapper(IServiceCollection services)
{
	var config = new MapperConfiguration(cfg =>
	{
		cfg.CreateMap<Business, BusinessDTO>().ReverseMap();
		cfg.CreateMap<Section, SectionDTO>().ReverseMap();
		cfg.CreateMap<Personnel, PersonnelDTO>().ReverseMap();
		cfg.CreateMap<Position, PositionDTO>().ReverseMap();
		cfg.CreateMap<PersonnelPosition, PersonnelPositionDTO>().ReverseMap();
	});
	var mapper = config.CreateMapper();
	services.AddSingleton(mapper);
	}
void RegisterServices(IServiceCollection services)
{
	services.AddScoped<IDbService, DbService>();
}