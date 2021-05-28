using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1SF1
{
    class Cook
    {
        public string name;
        public DishType specialization;
        public List<Order> Orders = new List<Order>();

        public Cook(string name, DishType specialization)
        {
            this.name = name;
            this.specialization = specialization;
        }
    }
}
