using Company.Data.Entities;

namespace Company.Data.Contexts;

public class CompanyContext : DbContext
{
    public DbSet<Business> Businesses => Set<Business>();
    public DbSet<Personnel> Personnel => Set<Personnel>();
    public DbSet<Section> Sections => Set<Section>();
    public DbSet<Position> Positions => Set<Position>();

    public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        SeedData(builder);
    }
    private void SeedData(ModelBuilder builder)
    {
        var businesses = new List<Business>()
        {
            new Business
            {
                Id = 1,
                CompanyName= "Min första Sverige AB",
                OrganisationsNumber = "1-234567890"
            }
        };
        builder.Entity<Business>().HasData(businesses);
        var sections = new List<Section>()
        {
            new Section
            {
                Id = 1,
                SectionName = "HR Sverige",
                CompanyId = 1,
            },
            new Section
            {
                Id = 2,
                SectionName = "Kvalitetskontroll Sverige",
                CompanyId = 1
            },
            new Section
            {
                Id = 3,
                SectionName = "Kök Sverige",
                CompanyId = 1
            }
        };
        builder.Entity<Section>().HasData(sections);
        var personnel = new List<Personnel>()
        {
            new Personnel 
            {
                Id = 1,
                Name = "Anders",
                Surname = "Svensson",
                SectionId= 1,
                Salary = 20000.00,
                UnionMember = true
            },
            new Personnel
            {
                Id = 2,
                Name = "Anna",
                Surname = "Svensdotter",
                SectionId= 2,
                Salary = 25000.00,
                UnionMember = true
            },
            new Personnel
            {
                Id = 3,
                Name = "Lars",
                Surname = "Lindkvist",
                SectionId= 2,
                Salary = 25000.00,
                UnionMember = false
            },
            new Personnel
            {
                Id = 4,
                Name = "Erik",
                Surname = "Nilsson",
                SectionId= 3,
                Salary = 23000.00,
                UnionMember = false
            },
            new Personnel
            {
                Id = 5,
                Name = "Karin",
                Surname = "Berglund",
                SectionId= 3,
                Salary = 25000,
                UnionMember = true
            },
            new Personnel
            {
                Id = 6,
                Name = "Peter",
                Surname = "Jonsson",
                SectionId= 3,
                Salary = 24000.00,
                UnionMember = true
            }
        };
        builder.Entity<Personnel>().HasData(personnel);
        var positions = new List<Position>()
        {
            new Position 
            { 
                Id = 1,
                PositionName= "Manager"
            },
            new Position
            {
                Id = 2,
                PositionName= "Junior Kvalitetsansvarig"
            },
            new Position
            {
                Id = 3,
                PositionName= "Master Kock"
            },
            new Position
            {
                Id = 4,
                PositionName= "Kock"
            },
            new Position
            {
                Id = 5,
                PositionName= "Praktikant"
            }
        };
        builder.Entity<Position>().HasData(positions);
    }
}

