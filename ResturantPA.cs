namespace Resturang_beställning
{
    public class ResturantPA
    {
        public async Task<int> takeOrder()
        {
            string[] food = new string[3] { "God Pasta", "WOW Burgare", "Best Pizza" };

            
            Console.WriteLine("Vad kan jag servera för dig? Svara med siffran 1,2 eller 3 från menyn nedan!");
            Console.WriteLine();
            Console.WriteLine("MENY: ");

            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {food[i]}");
            }

            int order = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine();
                Console.Write("Ange ditt val: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out order) && order >= 1 && order <= 3)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Ogiltigt val, försök igen.");
                }
            }
            order -= 1;
            Console.WriteLine($"Du har valt: {food[order]}");
            await Task.Delay(1000);
            Console.WriteLine("Din mat förbreds.");
            Console.WriteLine();

            return order;
        }

        public async Task Cook()
        {
            Console.Write("Ange namn för beställningen: ");
            string? name = Console.ReadLine();

            int order = await takeOrder();

            await Task.Run(async () =>
            {
                if (order == 0)
                {
                    PastaOrder pastaOrder = new PastaOrder(name, "Pasta Carbonara", 20, false);
                    await pastaOrder.Coock();
                }
                else if (order == 1)
                {
                    BurgarOrder burgarOrder = new BurgarOrder(name, "Cheezy Burger Cheeze", 10, false);
                    await burgarOrder.Coock();
                }
                else if (order == 2)
                {
                    PizzaOrder pizzaOrder = new PizzaOrder(name, "Kebabbig PIZZA", 20, false);
                    await pizzaOrder.Coock();
                }
            });

        }
    }

    
}
