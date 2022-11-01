namespace The_Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Restaurant restaurant = new Restaurant();
            Waiter waiter = new Waiter("");



            restaurant.Welcome();
            restaurant.CompaniesInQueue();
            waiter.PickUpCompanyInLine(restaurant.GuestList, restaurant.inQueueCompany);
            

        }
    }
}