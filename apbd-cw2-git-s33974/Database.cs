namespace apbd_cw2_git_s33974;

public class Database
{
    public List<User> users = new();
    public List<Equipment> equipments = new();
    public List<Lease> leases = new();

    public void RegisterUser(User user)
    {
        if (!users.Contains(user)) users.Add(user);
    }

    public void RegisterEquipment(Equipment e)
    {
        if (!equipments.Contains(e)) equipments.Add(e);
    }
//GŁÓWNA LOGIKA BIZNESOWA
    public void CreateLease(Equipment eq, User us, DateTime startDate, DateTime endDate, DateTime deadLine, double dailyRate)
    {
        bool allowed = true;
        int userOccurenceCounter = 0;
        string errorCause = "";
            if (!eq.available)
            {
                allowed = false;
                errorCause = $"Equipment {eq} already leased.";
            }
            
        foreach (Lease l in leases)
        {
            if (l.user.Equals(us) && !l.endDate.HasValue) userOccurenceCounter++;
        }
        
        if (userOccurenceCounter >= us.allowedLeaseCount)
        {
            allowed = false;
            errorCause = $"User {us} has reached their limit of active leases.";
        }
        if (allowed)
            leases.Add(new Lease(eq, us, startDate, endDate, deadLine, dailyRate));
        else Console.WriteLine("Could not create the lease object; " + errorCause);
    }

    public void printActiveLeaseReport()
    {
        
    }
    
    public void printCompleteReport()
    {   
        Console.WriteLine($"Users: {users.Count} \nEquipment pieces: {equipments.Count} \nLeases: {leases.Count}\n");
        Console.WriteLine("Users: ");
        foreach(var e in users)
            Console.WriteLine(e.ToString());
        Console.WriteLine("Equipments: ");
        foreach(var e in equipments)
            Console.WriteLine(e.ToString());
        Console.WriteLine("Leases: ");
        foreach(var e in leases)
            Console.WriteLine(e.ToString());
    }
}