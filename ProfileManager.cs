public class ProfileManager
{
    // This dictionary maps user IDs to User objects.
    // It allows for quick retrieval of user profiles by their ID.
    // Applied Problem TWO SUM (Using Dictionary)
    private Dictionary<int, User> profiles = new Dictionary<int, User>();

    // This HashSet is used to ensure that usernames are unique and not empty.
    // Applied Problem Contains Duplicate (Using HashSet)
    // It prevents the addition of duplicate usernames to the profiles.
    private
    HashSet<String> userNames = new HashSet<string>();

    // This list is used to store forbidden usernames, which can be extended as needed.
    private List<String> forbiddenUserNames = new List<string> { "admin", "root", "system", "guest", "user", "mod", "test" };

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

    public bool IsForbiddenUserName(string userName)
    {

        // Check if the username is an anagram of any forbidden usernames

        foreach (var forbiddenUserName in forbiddenUserNames)
        {
            if (AreAnagrams(userName, forbiddenUserName))
            {
                Console.WriteLine($"Username '{userName}' is an anagram of a forbidden username '{forbiddenUserName}'.");
                return true;
            }
        }

        return false;

    }

    // Helper method to check if two strings are anagrams of each other.
    // This method counts the occurrences of each character in both strings and compares them.
    // Applied Problem Anagram (Using Dictionary)
    // It returns true if the strings are anagrams, false otherwise.
    private bool AreAnagrams(string str1, string str2)
    {

        if (str1.Length != str2.Length)
        {
            return false;
        }

        var charCount = new Dictionary<char, int>();

        foreach (char c in str1)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        foreach (char c in str2)
        {
            if (!charCount.ContainsKey(c) || charCount[c] == 0)
            {
                return false;
            }
            charCount[c]--;
        }

        return true;

    }

}

