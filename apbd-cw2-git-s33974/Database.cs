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
    public void CreateLease(Equipment eq, User us, DateTime startDate, DateTime? endDate, DateTime deadLine,
        double dailyRate)
    {
        bool allowed = true;
        string errorCause = "";
        if (!eq.available)
        {
            errorCause = $"{eq.ToString()} already leased or unavailable.";
            Console.WriteLine("Could not create the lease object; " + errorCause);
        }

        else if (us.addLease())
            leases.Add(new Lease(eq, us, startDate, deadLine, endDate, dailyRate));
        else
        {   
            errorCause = $"User {us} has reached their limit of active leases.";
            Console.WriteLine("Could not create the lease object; " + errorCause);
        }
    }

    public void ReturnEquipment(int id)
    {
        foreach (Lease l in leases)
        {
            if (l.leaseID == id && !l.endDate.HasValue)
            {
                Console.WriteLine($"{l.leaseID} successfully returned. Penalty: {l.getPenalty()}");
                l.SetEndDate(DateTime.Now);
            }
            else if (l.leaseID == id) Console.WriteLine($"{l.leaseID} could not be returned. No active lease with this ID found.");
        }
    }
}