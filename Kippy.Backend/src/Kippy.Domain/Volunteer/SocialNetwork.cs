namespace Kippy.Domain.Volunteer;

public sealed class SocialNetwork
{
    public string Name { get; }
    
    public string Url { get; }

    public SocialNetwork(string name, string url)
    {
        Name = name;
        Url = url;
    }
}