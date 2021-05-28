using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1SF1
{
    enum DishType
    {
            Meat,
            Fish,
            Salad,
            Soup,
            Desserts
    }
    class Dish
        {
        public string name;
        public TimeSpan readyTime;
        public DishType dishType;

        public Dish(string name, TimeSpan readyTime, DishType dishType)
        {
            this.name = name;
            this.readyTime = readyTime;
            this.dishType = dishType;
        }
            

        public override bool Equals(Object dish)
        {
            return ((Dish)dish).GetHashCode().Equals(this.GetHashCode());
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, readyTime, dishType);
        }
    }
}

