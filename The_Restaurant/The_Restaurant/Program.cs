namespace The_Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Welcome();
            restaurant.DrawRestaurant();

            while (true)
            {
                Console.ReadKey();
                restaurant.PerformRound();
                restaurant.DrawRestaurant();
                
            }
        }
    }
}