namespace Resturang_beställning
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till resturang PA!");

            ResturantPA resturantPA = new ResturantPA();

            Task food1 = resturantPA.takeOrder();
            Task foodPrep = resturantPA.Cook();

            //Task food1 = Task.Run(() => resturantPA.takeOrder());
            //Task foodPrep = Task.Run(() => resturantPA.Cook());
            await foodPrep;



        }
    }
}
