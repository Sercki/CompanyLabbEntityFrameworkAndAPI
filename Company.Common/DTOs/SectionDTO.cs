using System.ComponentModel.DataAnnotations;

namespace Company.Common.DTOs;

public record SectionDTO
{
	public int Id { get; set; }
	public string SectionName { get; set; }
	public int CompanyId { get; set; }
}
