public class ProfileManager
{
    private Dictionary<int, User> profiles = new Dictionary<int, User>();

    private int nextId = 1;

    public void AddProfile(string userName)
    {
        User newUser = new User
        {
            Id = nextId,
            userName = userName
        };

        profiles[nextId] = newUser;
        nextId++;

        Console.WriteLine($"Profile added: {newUser.userName} with ID {newUser.Id}");
    }

    public User GetProfile(int id)
    {
        if (profiles.ContainsKey(id))
        {
            return profiles[id];
        }

        return null;
    }

}