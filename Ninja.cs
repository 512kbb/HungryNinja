using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungryNinja
{
    public class Ninja
    {
        private int CalorieInTake;
        public List<Food> FoodHistory;

        public Ninja()
        {
            CalorieInTake = 0;
            FoodHistory = new List<Food>();
        }

        public bool IsFull()
        {
            return CalorieInTake > 1200;
        }

        public void Eat(Food food)
        {
            if (IsFull()) {
                Console.WriteLine("The Ninja is not hungry anymore!");
                return;
            }
            FoodHistory.Add(food);
            int newCalorieInTake = CalorieInTake + food.Calories;
            CalorieInTake = newCalorieInTake;
            string sweetness = food.IsSweet ? "very sweet" : "not sweet";
            string spiciness  = food.IsSpicy ? "spicy as can get" : "not very spicy";
            Console.WriteLine($"{food.Name}, calories: {food.Calories}, {sweetness}, {spiciness}");

        }

    }
}