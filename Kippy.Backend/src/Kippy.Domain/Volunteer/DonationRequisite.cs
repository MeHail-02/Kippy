namespace Kippy.Domain.Volunteer;

public sealed class DonationRequisite 
{
    private string Name { get; }

    private string Description { get; }

    private string Value { get; }

    public DonationRequisite(string name, string description, string value)
    {
        Name = name;
        Description = description;
        Value = value;
    }
}