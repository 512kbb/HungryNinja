using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HungryNinja
{
    public class Buffet
    {
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>() {
                new Food("Tallarin Saltado", 300, true, false),
                new Food("Arroz con Papas Fritas", 500, false, false),
                new Food("Fideos con Salsa", 400, false, false),
                new Food("Champinon al ajillo", 300, true, false),
                new Food("Ñoquis", 500, false, false),
                new Food("Albondigas", 350, false, false),
                new Food("Crema de esparragos", 450, false, false)
            };
        }

        public Food Serve()
        {
            Random rand = new();
            return Menu[rand.Next(Menu.Count)];
        }
    }
}