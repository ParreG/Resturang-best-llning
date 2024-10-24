namespace Resturang_beställning
{
    public class ResturantPA
    {
        public async Task takeOrder()
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
            //await Task.Delay(1000);
            Console.WriteLine("Din mat förbreds.");
            Console.WriteLine();
            Console.Write("Ange namn för beställningen: ");
            string? name = Console.ReadLine();
            Order newOrder=null;

            if (order == 0)
            {
                newOrder = new PastaOrder(name, "Pasta Carbonara", 20, false);         
            }
            else if (order == 1)
            {
                newOrder = new BurgarOrder(name, "Cheezy Burger Cheeze", 10, false);
            }
            else if (order == 2)
            {
                newOrder = new PizzaOrder(name, "Kebabbig PIZZA", 20, false);
            }

            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */
                Cook(newOrder, cts);
            }).Start();

        }

        public async Task Cook(Order order, CancellationTokenSource cts)
        {
           await order.Coock();
           cts.Cancel();
        }
    }

    
}
