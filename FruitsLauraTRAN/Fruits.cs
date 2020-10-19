using System;
using System.Collections.Generic;
using System.Text;

namespace FruitsLauraTRAN
{
    public class Fruits
    {
        private string NameFruit { get; set; }
        public double Price { get; set; }

        public Fruits(string name)
        {
            NameFruit = name;
            if (name == "apple")
            {
                Price = 0.60;
            }
            else
            {
                if(name == "orange")
                {
                    Price = 0.25;
                }
                    
            }
        }

       
    }
}
