using CSharpFunctionalExtensions;

namespace Kippy.Domain.Volunteer;

public class Volunteer : Entity
{
    //ef core
    private Volunteer()
    {
        
    }

    private Volunteer(FullName fullName, 
        string email,
        string description,
        int experienceYears,
        string phoneNumber,
        IEnumerable<SocialNetwork> socialNetworks,
        IEnumerable<DonationRequisite> donationRequisites)

    {
        FullName = fullName;
        Email = email;
        Description = description;
        ExperienceYears = experienceYears;
        PhoneNumber = phoneNumber;
        SocialNetworks = new List<SocialNetwork>(socialNetworks);
        DonationRequisites = new List<DonationRequisite>(donationRequisites);
    }
    
    public new Guid Id { get; private set; }
    
    public FullName FullName { get; private set; }
    
    public string Email { get; private set; }
    
    public string Description { get; private set; }
    
    public int ExperienceYears { get; private set; }
    
    public int FoundHomePetsCount => OwnedPets.Count(p => p.HelpStatus == HelpStatus.FoundHome && 
    OwnedPets.Any(op => op.Id == p.Id));
    
    public int LookingForHomePetsCount => OwnedPets.Count(p => p.HelpStatus == HelpStatus.LookingForHome && 
    OwnedPets.Any(op => op.Id == p.Id));
    
    public int InTreatmentPetsCount =>  OwnedPets.Count(p => p.HelpStatus == HelpStatus.NeedsHelp && 
    OwnedPets.Any(op => op.Id == p.Id));
    
    public string PhoneNumber { get; private set; }
    
    public IReadOnlyList<SocialNetwork> SocialNetworks { get; private set; }
    
    public IReadOnlyList<DonationRequisite> DonationRequisites { get; private set; }
    
    public IReadOnlyList<Pet> OwnedPets { get; private set; }

    public void Create(FullName fullName,
        string email,
        string description,
        int experienceYears,
        string phoneNumber,
        IEnumerable<SocialNetwork> socialNetworks,
        IEnumerable<DonationRequisite> donationRequisites)
    {
        var volunteer = new Volunteer(fullName,
            email,
            description,
            experienceYears,
            phoneNumber,
            socialNetworks,
            donationRequisites
        );
    }
}