namespace Kippy.Domain.Volunteer;

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