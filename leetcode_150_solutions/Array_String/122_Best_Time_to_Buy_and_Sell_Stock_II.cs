public static class _122_Best_Time_to_Buy_and_Sell_Stock_II
{
    public static int MaxProfit(int[] prices)
    {
        int max_profit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] - prices[i - 1] > 0)
            {
                max_profit += prices[i] - prices[i - 1];
            }
        }
        return max_profit;
    }
}
