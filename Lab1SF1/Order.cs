using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1SF1
{
    class Order
    {
        private DateTime startTime;
        public DateTime StartTime { get { return startTime; } set { startTime = value; } }
        public Dictionary<Dish, int> Dishes = new Dictionary<Dish, int>();

        public Order(Dictionary<Dish, int> dishes)
        {
            Dishes = dishes;
        }

        public TimeSpan GetTimeToReady()
        {
            TimeSpan result = new TimeSpan();
            foreach (KeyValuePair<Dish, int> dish in Dishes)
            {
                result += dish.Key.readyTime * dish.Value;
            }
            return result;
        }
        
    }
}
