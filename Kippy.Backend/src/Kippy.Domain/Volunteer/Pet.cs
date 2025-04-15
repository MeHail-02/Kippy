using CSharpFunctionalExtensions;

namespace Kippy.Domain.Volunteer;

public class Pet : Entity
{
    // ef core
    private Pet()
    {
        
    }

    private Pet(string name,
        string species,
        string description,
        string breed,
        string color,
        string healthInfo,
        Address address,
        decimal weight,
        decimal height,
        string phoneNumber,
        bool isSterilized,
        DateTime birthDate,
        bool isVaccinated,
        HelpStatus helpStatus,
        IEnumerable<DonationRequisite> donationRequisites,
        DateTime createdDate,
        SpeciesInfo speciesInfo
        )
    {
        Name = name;
        Species = species;
        Description = description;
        Breed = breed;
        Color = color;
        HealthInfo = healthInfo;
        Address = address;
        Weight = weight;
        Height = height;
        PhoneNumber = phoneNumber;
        IsSterilized = isSterilized;
        BirthDate = birthDate;
        IsVaccinated = isVaccinated;
        HelpStatus = helpStatus;
        DonationRequisites = new List<DonationRequisite>(donationRequisites);
        CreatedDate = createdDate;
        SpeciesInfo = speciesInfo;
    }
    
    public new Guid Id { get; private set; }
    
    public string Name { get; private set; } 
    
    public string Species { get; private set; } 
    
    public string Description { get; private set; } 
    
    public string Breed { get; private set; } 

    public string Color { get; private set; } 
    
    public string HealthInfo { get; private set; }
    
    public Address Address { get; private set; }
    
    public decimal Weight { get; private set; }
    
    public decimal Height { get; private set; }
    
    public string PhoneNumber { get; private set; }

    public bool IsSterilized { get; private set; }
    
    public DateTime BirthDate { get; private set; }
    
    public bool IsVaccinated { get; private set; }
    
    public HelpStatus HelpStatus { get; private set; }

    public IReadOnlyList<DonationRequisite> DonationRequisites { get; private set; }
    
    public DateTime CreatedDate { get; private set; }
    
    public SpeciesInfo SpeciesInfo { get; private set; }

    public static void Create(string name,
        string species,
        string description,
        string breed,
        string color,
        string healthInfo,
        Address address,
        decimal weight,
        decimal height,
        string phoneNumber,
        bool isSterilized,
        DateTime birthDate,
        bool isVaccinated,
        IEnumerable<DonationRequisite> donationRequisites,
        SpeciesInfo speciesInfo)
    {
        var pet = new Pet(name,
            species,
            description,
            breed,
            color,
            healthInfo,
            address,
            weight,
            height,
            phoneNumber,
            isSterilized,
            birthDate,
            isVaccinated,
            HelpStatus.NeedsHelp, // По умолчанию "Нуждается в помощи"
            donationRequisites,
            DateTime.UtcNow,
            speciesInfo);
    }
}

public sealed class Address 
{
    private string City { get; }
    
    private string Street { get; }
    
    private string Building  { get; }
    
    private string Apartment { get; }

    public Address(string city, string street, string building, string apartment)
    {
        City = city;
        Street = street;
        Building = building;
        Apartment = apartment;
    }
    
}

public sealed class SpeciesInfo
{
    public int SpeciesId { get; }
    
    public int BreedId { get; }

    public SpeciesInfo(int speciesId, int breedId)
    {
        SpeciesId = speciesId;
        BreedId = breedId;
    }
}


public enum HelpStatus
{
    NeedsHelp,    // Нуждается в помощи
    LookingForHome, // Ищет дом
    FoundHome      // Нашел дом
}