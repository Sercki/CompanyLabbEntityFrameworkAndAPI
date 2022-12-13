namespace Company.Data.Entities;

public class Position : IEntity
{
    public int Id { get; set; }

    [MaxLength(50),Required]
    public string PositionName { get; set; }

    public virtual ICollection<Personnel>? Personnel { get; set; }
}
