public class ProfileManager
{
    private Dictionary<int, User> profiles = new Dictionary<int, User>();
    HashSet<String> userNames = new HashSet<string>();
    private int nextId = 1;

    /* 
    Represents a user profile.
    This class manages user profiles, allowing for adding and retrieving profiles by ID. - Applied Problem TWO SUM (Using Dictionary)
    It ensures that usernames are unique and not empty when adding a new profile. - Applied Problem Containes Duplicate (Using HashSet)
    */
    public void AddProfile(string userName)
    {
        if (userNames.Contains(userName) || string.IsNullOrEmpty(userName))
        {
            Console.WriteLine("Invalid or duplicate username.");
            return;
        }
        else
        {
            userNames.Add(userName);
        }
        User newUser = new User
        {
            Id = nextId,
            userName = userName
        };

        if (!userNames.Contains(newUser.userName))
        {
            profiles[nextId] = newUser;
        }

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