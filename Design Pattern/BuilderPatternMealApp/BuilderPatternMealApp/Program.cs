using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuilderPatternMealApp.Model;
using System.Threading.Tasks;

namespace BuilderPatternMealApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("=== Veg Meal ===");
            vegMeal.ShowItems();
            Console.WriteLine("Total cost :   " + vegMeal.GetCost() + "\n");

            Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("=== Non Veg Meal ===");
            nonVegMeal.ShowItems();
            Console.WriteLine("Total cost :   " + nonVegMeal.GetCost() + "\n");
        }
    }
}
