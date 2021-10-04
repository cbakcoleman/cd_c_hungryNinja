using System;
using System.Collections.Generic;

namespace cd_c_hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet mybuffet = new Buffet();
            Ninja myninja = new Ninja();

            while(!myninja.IsFull)
            {
                myninja.Eat(mybuffet.Serve());
            }
        }
    }
}
