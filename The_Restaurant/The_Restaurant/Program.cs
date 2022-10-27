namespace The_Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            GUI gUI = new GUI();
            Company company = new Company();
            Waiter waiter = new Waiter("Ulla");
            List<Guest> eachCompany = new List<Guest>();
            gUI.Tables();
            eachCompany = company.BuildingCompany();

            waiter.PickUpCompany(eachCompany);


            
        }
    }
}