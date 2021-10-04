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
            List<Food> FoodHistory = new List<Food>();
        } // END NINJA CONSTRUCTOR

        public bool IsFull
        {
            
            get
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                else 
                {  
                    return false;
                }
            }
        } // END GETTER ISFULL

        public void Eat(Food item)
        {
            if (IsFull == false)
            {
                calorieIntake -= item.Calories;
            }
            if (IsFull == true)
            {
                System.Console.WriteLine("Ninja is full and can not eat anymore!");
            }
        } // END EAT METHOD

    } // END NINJA CLASS


}