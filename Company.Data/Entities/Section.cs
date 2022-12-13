namespace Company.Data.Entities;

public class Section: IEntity
{
    public int Id { get; set; }

    [MaxLength(50), Required]
    public string SectionName { get; set; }

    public int CompanyId { get; set; }
    public virtual Business? Company { get; set; }
    public virtual ICollection<Personnel>? Personnel { get; set; }
}
