using System;
using System.Collections.Generic;

namespace cd_c_hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Buffet> mybuffet = new List<Buffet>();
            Ninja myninja = new Ninja();

            foreach(var item in mybuffet)
            {
                if (myninja.IsFull == false)
                {
                    myninja.Eat(item);
                }
            }
        }
    }
}
