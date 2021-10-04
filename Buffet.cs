using System;
using System.Collections.Generic;

namespace cd_c_hungryNinja
{

    class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("SoonDubu Jigae", 500, true, false),
                new Food("Meatloaf", 700, false, false),
                new Food("Chicken Paprikash", 1200, false, false),
                new Food("Tiramisu", 1200, false, true),
                new Food("Fruit Tart", 800, false, true)
            }; // END MENU
        } // END BUFFET CONSTRUCTOR

        public Food Serve()
        {
            Random rando = new Random();
            int idx = rando.Next(Menu.Count);
            return (Menu[idx]);
        } // END SERVE METHOD

        


    } // END BUFFET CLASS

}