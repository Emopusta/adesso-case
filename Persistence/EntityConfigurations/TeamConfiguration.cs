using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class TeamConfiguration : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.ToTable("Teams").HasKey(t => t.Id);

        builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
        builder.Property(t => t.Name).HasColumnName("Name");
        builder.Property(t => t.CountryId).HasColumnName("CountryId");
        builder.Property(t => t.GroupId).HasColumnName("GroupId");
        builder.Property(t => t.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(t => t.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(t => t.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(t => !t.DeletedDate.HasValue);

        builder.HasData(getSeeds());
    }

    private IEnumerable<Team> getSeeds()
    {
        List<Team> teams = new();

        Team adessoIstanbul = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("d2bc1850-e738-49a2-b262-08dbe128c8cd"),
            GroupId = null,
            Name = "Adesso Istanbul",
        };
        Team adessoAnkara = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("d2bc1850-e738-49a2-b262-08dbe128c8cd"),
            GroupId = null,
            Name = "Adesso Ankara",
        };
        Team adessoIzmir = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("d2bc1850-e738-49a2-b262-08dbe128c8cd"),
            GroupId = null,
            Name = "Adesso Izmir",
        };
        Team adessoAntalya = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("d2bc1850-e738-49a2-b262-08dbe128c8cd"),
            GroupId = null,
            Name = "Adesso Antalya",
        };

        Team adessoBerlin = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("d3749aac-ed3e-442e-8206-d508b1b94dcc"),
            GroupId = null,
            Name = "Adesso Berlin",
        };
        Team adessoFrankfurt = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("d3749aac-ed3e-442e-8206-d508b1b94dcc"),
            GroupId = null,
            Name = "Adesso Frankfurt",
        };
        Team adessoMunih = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("d3749aac-ed3e-442e-8206-d508b1b94dcc"),
            GroupId = null,
            Name = "Adesso Munih",
        };
        Team adessoDortmund = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("d3749aac-ed3e-442e-8206-d508b1b94dcc"),
            GroupId = null,
            Name = "Adesso Dortmund",
        };

        Team adessoParis = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("2fafbee5-f65d-48a5-8637-270a9ae5cd4c"),
            GroupId = null,
            Name = "Adesso Paris",
        };
        Team adessoMarsilya = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("2fafbee5-f65d-48a5-8637-270a9ae5cd4c"),
            GroupId = null,
            Name = "Adesso Marsilya",
        };
        Team adessoNice = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("2fafbee5-f65d-48a5-8637-270a9ae5cd4c"),
            GroupId = null,
            Name = "Adesso Nice",
        };
        Team adessoLyon = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("2fafbee5-f65d-48a5-8637-270a9ae5cd4c"),
            GroupId = null,
            Name = "Adesso Lyon",
        };

        Team adessoAmsterdam = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("34a9d6f9-26aa-4cc6-96fc-7cf6f46e13eb"),
            GroupId = null,
            Name = "Adesso Amsterdam",
        };
        Team adessoRotterdam = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("34a9d6f9-26aa-4cc6-96fc-7cf6f46e13eb"),
            GroupId = null,
            Name = "Adesso Rotterdam",
        };
        Team adessoLahey = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("34a9d6f9-26aa-4cc6-96fc-7cf6f46e13eb"),
            GroupId = null,
            Name = "Adesso Lahey",
        };
        Team adessoEindhoven = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("34a9d6f9-26aa-4cc6-96fc-7cf6f46e13eb"),
            GroupId = null,
            Name = "Adesso Eindhoven",
        };

        Team adessoLisbon = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("f5f76ad1-25ba-452c-90c0-2c1f33df58db"),
            GroupId = null,
            Name = "Adesso Lisbon",
        };
        Team adessoPorto = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("f5f76ad1-25ba-452c-90c0-2c1f33df58db"),
            GroupId = null,
            Name = "Adesso Porto",
        };
        Team adessoBraga = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("f5f76ad1-25ba-452c-90c0-2c1f33df58db"),
            GroupId = null,
            Name = "Adesso Braga",
        };
        Team adessoCoimbra = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("f5f76ad1-25ba-452c-90c0-2c1f33df58db"),
            GroupId = null,
            Name = "Adesso Coimbra",
        };

        Team adessoRoma = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("35cd46ac-8347-48c1-8e5b-c631eb655d79"),
            GroupId = null,
            Name = "Adesso Roma",
        };
        Team adessoMilano = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("35cd46ac-8347-48c1-8e5b-c631eb655d79"),
            GroupId = null,
            Name = "Adesso Milano",
        };
        Team adessoVenedik = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("35cd46ac-8347-48c1-8e5b-c631eb655d79"),
            GroupId = null,
            Name = "Adesso Venedik",
        };
        Team adessoNapoli = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("35cd46ac-8347-48c1-8e5b-c631eb655d79"),
            GroupId = null,
            Name = "Adesso Napoli",
        };

        Team adessoSevilla = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("a7170631-6b14-4e7e-b2a9-22bb1403ab8a"),
            GroupId = null,
            Name = "Adesso Sevilla",
        };
        Team adessoMadrid = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("a7170631-6b14-4e7e-b2a9-22bb1403ab8a"),
            GroupId = null,
            Name = "Adesso Madrid",
        };
        Team adessoBarselona = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("a7170631-6b14-4e7e-b2a9-22bb1403ab8a"),
            GroupId = null,
            Name = "Adesso Barselona",
        };
        Team adessoGranada = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("a7170631-6b14-4e7e-b2a9-22bb1403ab8a"),
            GroupId = null,
            Name = "Adesso Granada",
        };

        Team adessoBruksel = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("4067b3e2-d378-46a4-a25b-cc5be4c24472"),
            GroupId = null,
            Name = "Adesso Bruksel",
        };
        Team adessoBrugge = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("4067b3e2-d378-46a4-a25b-cc5be4c24472"),
            GroupId = null,
            Name = "Adesso Brugge",
        };
        Team adessoGent = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("4067b3e2-d378-46a4-a25b-cc5be4c24472"),
            GroupId = null,
            Name = "Adesso Gent",
        };
        Team adessoAnvers = new()
        {
            Id = Guid.NewGuid(),
            CountryId = Guid.Parse("4067b3e2-d378-46a4-a25b-cc5be4c24472"),
            GroupId = null,
            Name = "Adesso Anvers",
        };

        teams.Add(adessoIstanbul);
        teams.Add(adessoAntalya);
        teams.Add(adessoIzmir);
        teams.Add(adessoAnkara);

        teams.Add(adessoBerlin);
        teams.Add(adessoDortmund);
        teams.Add(adessoMunih);
        teams.Add(adessoFrankfurt);
        
        teams.Add(adessoParis);
        teams.Add(adessoLyon);
        teams.Add(adessoMarsilya);
        teams.Add(adessoNice);

        teams.Add(adessoEindhoven);
        teams.Add(adessoAmsterdam);
        teams.Add(adessoLahey);
        teams.Add(adessoRotterdam);

        teams.Add(adessoLisbon);
        teams.Add(adessoPorto);
        teams.Add(adessoBraga);
        teams.Add(adessoCoimbra);

        teams.Add(adessoRoma);
        teams.Add(adessoMilano);
        teams.Add(adessoVenedik);
        teams.Add(adessoNapoli);

        teams.Add(adessoSevilla);
        teams.Add(adessoMadrid);
        teams.Add(adessoBarselona);
        teams.Add(adessoGranada);

        teams.Add(adessoBruksel);
        teams.Add(adessoBrugge);
        teams.Add(adessoGent);
        teams.Add(adessoAnvers);



        return teams.ToArray();
    }

    }