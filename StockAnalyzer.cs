public class StockAnalyzer
{
    public int FindMaxProfit(int[] prices)
    {
        //uses greedy algorithm to find the maximum profit
        //Because Everytime it assumes the lowest price is the first element

        int lowestPrice = int.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            int currentPrice = prices[i];

            if (currentPrice < lowestPrice)
            {
                lowestPrice = currentPrice;
            }
                else if (currentPrice - lowestPrice > maxProfit)
                {
                    maxProfit = currentPrice - lowestPrice;
                }
            }
    
            return maxProfit;
        }
    }
