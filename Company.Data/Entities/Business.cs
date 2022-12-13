namespace Company.Data.Entities;

public class Business: IEntity
{
    public int Id { get; set; }

    [MaxLength(50), Required]
    public string CompanyName { get; set; }

    [MaxLength(11), Required]
    public string? OrganisationsNumber { get; set; }

    public virtual ICollection<Section>? Sections { get; set; }
}
