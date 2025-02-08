public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length == 1) return 0;
        int buy_price = prices[0];
        int profit = 0;

        // The key is to buy at the lowest price and sell at the highest price.
        foreach (int i in prices)
        {
            if(buy_price > i)
                buy_price = i; 
            else if(i - buy_price > profit) 
                profit = i - buy_price;
        }
        return profit;
    }
}