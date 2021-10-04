using System;
using System.Collections.Generic;

namespace cd_c_hungryNinja
{

    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        } // END NINJA CONSTRUCTOR

        public bool IsFull
        {
            
            get
            {
                return calorieIntake > 1200;
            }
        } // END GETTER ISFULL

        public bool Eat(Food item)
        {
            if (!IsFull)
            {
                calorieIntake -= item.Calories;
                FoodHistory.Add(item);
                System.Console.WriteLine($"Ninja eats {item.Name}");
            }
            else
            {
                System.Console.WriteLine("Ninja is full and can not eat anymore!");
            }
            return IsFull;
        } // END EAT METHOD

    } // END NINJA CLASS


}