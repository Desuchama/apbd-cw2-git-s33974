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