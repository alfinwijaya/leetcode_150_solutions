public static class _121_Best_Time_to_Buy_and_Sell_Stock
{
    public static int MaxProfit(int[] prices)
    {
        int cheapestBuy = prices[0];
        int maxProfit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < cheapestBuy)
            {
                cheapestBuy = prices[i];
            }

            if (prices[i] - cheapestBuy > maxProfit)
            {
                maxProfit = prices[i] - cheapestBuy;
            }
        }
        return maxProfit;
    }
}
