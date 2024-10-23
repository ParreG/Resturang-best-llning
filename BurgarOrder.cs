using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturang_beställning
{
    internal class BurgarOrder : Order
    {
        public BurgarOrder(string orderName, string dishName, int cookingTime, bool delivery) :
            base(orderName, dishName, cookingTime, delivery)
        {

        }

        public async Task Coock()
        {
            Console.WriteLine($"Nu lagas {DishName}. Det tar 20 sekunder.");
            await Task.Delay(CookingTime * 1000);
            Console.WriteLine($"{OrderName}, din mat {DishName} är klar och serveras. Smaklig måltid.");
        }
    }
}
