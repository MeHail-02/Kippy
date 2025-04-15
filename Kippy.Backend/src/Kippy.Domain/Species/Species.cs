namespace Kippy.Domain.Species;

public class Species
{
    public Guid SpeciesId { get; private set; }
    
    public string Name { get; private set; }
    
    public IReadOnlyList<Breed> Breeds { get; private set; }

    public Species(string name, IEnumerable<Breed> breeds)
    {
        Name = name;
        Breeds = new List<Breed>(breeds);
    }
    
}