namespace The_Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            Table table = new Table(false, false, 0, 0);
            GUI gUI = new GUI();
            Company company = new Company();
            Waiter waiter = new Waiter("Ulla");
            TableOne tableOne = new TableOne(false, false, 0, 0);
            List<Guest> eachCompany = new List<Guest>();
            gUI.Tables();

            
            eachCompany = company.BuildingCompany();
            waiter.PickUpCompany(eachCompany);

            eachCompany = company.BuildingCompany();
            table.IsOccupied = waiter.PickUpCompany(eachCompany);

            eachCompany = company.BuildingCompany();;
            table.IsOccupied = waiter.PickUpCompany(eachCompany);


            Console.ReadKey();
            

            
        }
    }
}