using System;
using System.Collections.Generic;

ProfileManager profileManager = new ProfileManager();

profileManager.AddProfile("Alice");
profileManager.AddProfile("Bob");

User aliceProfile = profileManager.GetProfile(1);
if (aliceProfile != null)
{
    Console.WriteLine($"Retrieved Profile: {aliceProfile.userName} with ID {aliceProfile.Id}");
}
else
{
    Console.WriteLine("Profile not found.");
}

User bobProfile = profileManager.GetProfile(2);
if (bobProfile != null)
{
    Console.WriteLine($"Retrieved Profile: {bobProfile.userName} with ID {bobProfile.Id}");
}
else
{
    Console.WriteLine("Profile not found.");
}   