using System.Runtime.CompilerServices;

namespace Resturang_beställning
{
    public class PastaOrder : Order
    {
        public PastaOrder(string orderName, string dishName, int cookingTime, bool delivery) :
            base(orderName, dishName, cookingTime, delivery)
        {
            Console.WriteLine($"Nu lagas {DishName}. Det tar 20 sekunder.");
        }

        public override Task Coock()
        {
            Thread.Sleep(CookingTime * 1000);
            Console.WriteLine($"{OrderName}, din mat {DishName} är klar och serveras. Smaklig måltid.");
            return Task.CompletedTask;
        }
    
    }
}
