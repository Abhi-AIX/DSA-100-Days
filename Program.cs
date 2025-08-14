using System;
using System.Collections.Generic;

Console.WriteLine("\n--- Day 1: Profile Manager ---");

//Create a instance of ProfileManager
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

Console.WriteLine("\n--- Day 2: Stock Analyzer ---");
// Create an instance of StockAnalyzer
StockAnalyzer stockAnalyzer = new StockAnalyzer();

// Example stock prices
int[] prices = { 7, 1, 5, 3, 6, 4 };

// Find the maximum profit
int maxProfit = stockAnalyzer.FindMaxProfit(prices);
Console.WriteLine($"Maximum Profit: {maxProfit}");

// Example with no profit
int[] noProfitPrices = { 7, 6, 4, 3, 1 };
int noProfit = stockAnalyzer.FindMaxProfit(noProfitPrices);
Console.WriteLine($"Maximum Profit with no profit scenario: {noProfit}");

// Example with single price
int[] singlePrice = { 5 };
int singlePriceProfit = stockAnalyzer.FindMaxProfit(singlePrice);
Console.WriteLine($"Maximum Profit with single price: {singlePriceProfit}");

// Example with empty array
int[] emptyPrices = {};
int emptyProfit = stockAnalyzer.FindMaxProfit(emptyPrices);
Console.WriteLine($"Maximum Profit with empty array: {emptyProfit}");

Console.WriteLine("\n--- Day 3: Resrtrict Duplicate UserNames ---");
// Create an instance of ProfileManager
ProfileManager profileManagerWithDupCheck = new ProfileManager();

// Add profiles with unique usernames
profileManagerWithDupCheck.AddProfile("Charlie");
profileManagerWithDupCheck.AddProfile("David");

// Attempt to add a profile with a duplicate username
profileManagerWithDupCheck.AddProfile("Charlie"); // Should print an error message

// Attempt to add a profile with an empty username
profileManagerWithDupCheck.AddProfile(""); // Should print an error message
