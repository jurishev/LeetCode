namespace Tiq.Easy.Array
{
    public class BestTimeToBuyAndSell
    {
        public int MaxProfit(int[] prices)
        {
            var bought = false;
            var profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                var isLastDay = i == prices.Length - 1;
                var shouldSell = isLastDay || prices[i] > prices[i + 1];
                var shouldBuy = !isLastDay && prices[i] < prices[i + 1];

                if (bought)
                {
                    if (shouldSell)
                    {
                        profit += prices[i];
                        bought = false;
                    }
                }
                else if (shouldBuy)
                {
                    profit -= prices[i];
                    bought = true;
                }
            }

            return profit;
        }
    }
}
