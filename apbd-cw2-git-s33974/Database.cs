namespace apbd_cw2_git_s33974;

public class Database
{
    public List<User> users = new List<User>();
    public List<Equipment> equipments = new List<Equipment>();
    public List<Lease> leases = new List<Lease>();
    
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