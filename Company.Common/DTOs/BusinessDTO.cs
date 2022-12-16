using System.ComponentModel.DataAnnotations;

namespace Company.Common.DTOs;

public record BusinessDTO
{
	public int Id { get; set; }
	public string CompanyName { get; set; }
	public string? OrganisationsNumber { get; set; }
}
