namespace Kippy.Domain.Species;

public class Breed
{
    public Guid BreedId { get; private set; }
    
    public string Name { get; private set; }

    public Breed(string name)
    {
        Name = name;
    }
}