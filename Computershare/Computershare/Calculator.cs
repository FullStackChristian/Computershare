using System;
namespace Computershare
{
    public class Calculator
    {
        /// <summary>
        /// Determines the max difference between two values depending on days, outputs BUY and SELL Recommendation to console
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="arr_size"></param>
        public void MaxDiff(float[] arr, int arr_size)
        {
            //Take Day 1 and find the difference with all the following days
            //Do same for all the other days BUT Day 2 can't get the difference from Day 1 as Day 1
            //is in the past and we don't have the DeLorean yet...

            DayOfMonth buyDay = new DayOfMonth();
            DayOfMonth sellDay = new DayOfMonth();

            float max_diff = arr[1] - arr[0];
            int i, j;
            
            for (i = 0; i < arr_size; i++)
            {
                for (j = i + 1; j < arr_size; j++)
                {
                    if (arr[j] - arr[i] > max_diff)
                    {
                        max_diff = arr[j] - arr[i];

                        //Store latest values for i and j to access later
                        buyDay.Day = i;
                        buyDay.DayPrice = arr[i];
                        sellDay.Day = j;
                        sellDay.DayPrice = arr[j];
                    }
                }
             }
            string buyDayOfMonth = $"{ buyDay.Day }({ buyDay.DayPrice })";
            string sellDayOfMonth = $"{ sellDay.Day }({ sellDay.DayPrice} )";
            //For the final output:
            Console.WriteLine($"{buyDayOfMonth},{sellDayOfMonth}"); 
        }
    }
}
