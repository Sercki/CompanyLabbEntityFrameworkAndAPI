namespace Company.Data.Entities;

public class Personnel : IEntity
{
    public int Id { get; set; }

    [MaxLength(50), Required]
    public string Name { get; set; }

    [MaxLength(50), Required]
    public string? Surname { get; set; }

    [Required]
    public double? Salary { get; set; }

    [Required]
    public bool? UnionMember { get; set; }

    public int SectionId { get; set; }
    public virtual Section? Section { get; set; }
    public virtual ICollection<Position>? Positions { get; set; }
}
