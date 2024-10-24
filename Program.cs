namespace Resturang_beställning
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till resturang PA!");

            ResturantPA resturantPA = new ResturantPA();
            while (true)
            {
                await resturantPA.takeOrder();
            }
             


            //Task food1 = Task.Run(() => resturantPA.takeOrder());
            //Task foodPrep = Task.Run(() => resturantPA.Cook());
          



        }
    }
}
