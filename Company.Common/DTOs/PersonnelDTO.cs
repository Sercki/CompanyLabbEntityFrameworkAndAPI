using System.ComponentModel.DataAnnotations;

namespace Company.Common.DTOs;

public record PersonnelDTO
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string? Surname { get; set; }
	public int SectionId { get; set; }
	public double? Salary { get; set; }
	public bool? UnionMember { get; set; }	
}
