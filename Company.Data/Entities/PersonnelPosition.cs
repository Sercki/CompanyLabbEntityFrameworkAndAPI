namespace Company.Data.Entities;

public class PersonnelPosition : IReferenceEntity
{
	public int PersonnelId { get; set; }
	public int PositionId { get; set; }

	public virtual Personnel? Personnel { get; set; }
	public virtual Position? Position { get; set; }	
}

