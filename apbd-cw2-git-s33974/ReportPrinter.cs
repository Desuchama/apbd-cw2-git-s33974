namespace apbd_cw2_git_s33974;

public class ReportPrinter(Database db)
{
    public Database database = db;
    
    public void printActiveLeaseReport()
    {
        Console.WriteLine("Active leases: ");
        foreach (Lease l in database.leases)
        {
            if (!l.endDate.HasValue) 
                Console.WriteLine(l.ToString());
        }
    }

    public void printPenalties()
    {
        Console.WriteLine("Penalties: ");
        foreach (Lease l in database.leases)
            Console.WriteLine("ID: " + l.leaseID +": "+ l.getPenalty());
    }
    
    public void printCompleteReport()
    {   
        Console.WriteLine($"Users: {database.users.Count} \nEquipment pieces: {database.equipments.Count} \nLeases: {database.leases.Count}");
        Console.WriteLine("Users: ");
        foreach(var e in database.users)
            Console.WriteLine(e.ToString());
        Console.WriteLine("Equipments: ");
        foreach(var e in database.equipments)
            Console.WriteLine(e.ToString());
        Console.WriteLine("Leases: ");
        foreach(var e in database.leases)
            Console.WriteLine(e.ToString());
    }
}