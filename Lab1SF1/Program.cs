using System;
using System.Collections.Generic;

namespace Lab1SF1
{
    class Program
    {
        static void Main()
        {
            List<Cook> Cooks = new List<Cook>(5);
            Cooks.Add(new Cook("Андрей", DishType.Meat));
            Cooks.Add(new Cook("Иван", DishType.Fish));
            Cooks.Add(new Cook("Александр", DishType.Salad));
            Cooks.Add(new Cook("Дмитрий", DishType.Soup));
            Cooks.Add(new Cook("Оксана", DishType.Desserts));

            Console.WriteLine("Текущее время: " + DateTime.Now.ToString("HH:mm"));

            Dictionary<Dish, int> Dishes = new Dictionary<Dish, int>();
            Dishes.Add(new Dish("Свинной стейк", TimeSpan.FromMinutes(20), DishType.Meat), 2);
            /*foreach (Dish dish in Dishes)
            {
                Console.WriteLine(dish.name + " - " + dish.readyTime.Minutes + " минут");
            }*/
            Dictionary<Dish, int> Dishes1 = new Dictionary<Dish, int>();
            Dishes1.Add(new Dish("Котлета", TimeSpan.FromMinutes(15), DishType.Meat), 1);
            /*Dishes1.Add(new Dish("Наполеон", TimeSpan.FromMinutes(12), DishType.Desserts), 1);
            /*foreach (Dish dish in Dishes1)
            {
                Console.WriteLine(dish.name + " - " + dish.readyTime.Minutes + " минут");
            }*/
            Console.WriteLine("--------------------");
            List <Order> Orders = new List<Order>();
            Orders.Add(new Order(Dishes));
            Orders.Add(new Order(Dishes1));

            Kitchen kitchen = new Kitchen(Cooks, Orders);
            kitchen.DistributeOrders();
            Console.WriteLine("Начало выполнения первого заказа: " + kitchen.GetOrder(0).StartTime.ToString("HH:mm"));
            Console.WriteLine("Начало выполнения второго заказа: " + kitchen.GetOrder(1).StartTime.ToString("HH:mm"));
        }
    }
}