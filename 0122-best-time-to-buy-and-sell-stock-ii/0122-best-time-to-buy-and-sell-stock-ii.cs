public class Solution {
    public int MaxProfit(int[] prices) {

        int buy_price = prices[0];
        int profit = 0;
        int now_price = 0;
        //If value of the next day is higher than buy_price, Add the profit to total
        for (int i = 1 ; i < prices.Length ; i++)
        {
            now_price = prices[i];
            if(buy_price > now_price) 
            {
                buy_price = now_price;
            }
            else if(buy_price < now_price)
            {
                profit += now_price - buy_price;
                buy_price = now_price;
            }
        }
        return profit;
    }
}