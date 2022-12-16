using System.ComponentModel.DataAnnotations;

namespace Company.Common.DTOs;

public record PositionDTO
{
	public int Id { get; set; }
	public string PositionName { get; set; }
}
