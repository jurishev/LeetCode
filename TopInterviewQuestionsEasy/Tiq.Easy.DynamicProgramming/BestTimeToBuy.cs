﻿namespace Tiq.Easy.DynamicProgramming
{
    public class BestTimeToBuy
    {
        public int MaxProfit(int[] prices)
        {
            if (prices is null || prices.Length < 2)
            {
                return 0;
            }

            int minPrice = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }

            return maxProfit;
        }
    }
}
