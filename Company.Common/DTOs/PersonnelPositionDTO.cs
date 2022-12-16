namespace Company.Common.DTOs;

public record PersonnelPositionDTO
{
	public int PersonnelId { get; set; } = default;
	public int PositionsId { get; set; } = default;
	public PersonnelPositionDTO(int personnelID, int positionsId ) => (PersonnelId, PositionsId) = (personnelID, positionsId);
}
