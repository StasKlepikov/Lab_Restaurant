using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1SF1
{
    class Kitchen
    {
        private List<Cook> Cooks = new List<Cook>();
        private List<Order> Orders = new List<Order>();


        public Kitchen(List<Cook> cooks, List<Order> orders)
        {
            Cooks = cooks;
            Orders = orders;
        }

        /*public void PrepareNextOrder() {
            Order order = Orders[0];
            foreach (Cook cook in Cooks) 
            {
                cook.PrepareDish(order);
            }
            Orders.Remove(order);
        }*/
        
        public void DistributeOrders()
        {

            foreach (Cook cook in Cooks)
            {
                foreach (Order order in Orders)
                {
                    if (cook.specialization.Equals(order.Dishes.First().Key.dishType))
                    {
                        if (!cook.Orders.Any())
                            order.StartTime = DateTime.Now;
                        else
                        {
                            Order lastOrder = cook.Orders.Last();
                            order.StartTime = lastOrder.StartTime.Add(lastOrder.GetTimeToReady());
                        }
                        cook.Orders.Add(order);
                    }
                }
            }
        }
        public Order GetOrder(int i) 
        {
            return Orders[i];
        }
    }
}
