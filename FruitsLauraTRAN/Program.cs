using System;
using System.Collections.Generic;

namespace FruitsLauraTRAN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fruits> listFruit = new List<Fruits>();
            double cost = 0;

            Fruits fruitA = new Fruits("appleA");
            listFruit.Add(fruitA);
            Fruits fruitB = new Fruits("orangeA");
            listFruit.Add(fruitB);
            Fruits fruitC = new Fruits("appleB");
            listFruit.Add(fruitC);
            Fruits fruitD = new Fruits("orangeB");
            listFruit.Add(fruitD);

            foreach (Fruits fruit in listFruit)
            {
                cost = cost + fruit.Price;
            }
            Console.WriteLine(cost);
            Console.ReadKey();
        }
    }
}
