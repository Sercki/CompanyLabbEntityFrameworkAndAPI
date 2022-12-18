namespace Company.Common.DTOs;

public record PersonnelPositionDTO
{
	public int PersonnelId { get; set; } = default;
	public int PositionId { get; set; } = default;
	public PersonnelPositionDTO(int personnelID, int positionId ) => (PersonnelId, PositionId) = (personnelID, positionId);
}
