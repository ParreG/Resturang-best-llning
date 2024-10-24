using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturang_beställning
{
    public class PizzaOrder : Order
    {
        public PizzaOrder(string orderName, string dishName, int cookingTime, bool delivery) : 
            base(orderName, dishName, cookingTime, delivery)
        {
            Console.WriteLine($"Nu lagas {DishName}. Det tar {CookingTime} sekunder.");
        }

        public override async Task Coock()
        {        
           
            Thread.Sleep(CookingTime * 1000);
            Console.WriteLine($"{OrderName}, din mat {DishName} är klar och serveras. Smaklig måltid.");
        }
    }
}
