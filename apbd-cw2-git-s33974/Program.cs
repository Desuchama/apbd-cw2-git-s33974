using apbd_cw2_git_s33974;

public class Program
{
    public static void Main(string[] args)
    {
        Database db = new Database();
        
        Employee e1 = new Employee("Abel", "-");
        Employee e2 = new Employee("Cain", "-");
        Console.WriteLine(e1.ToString());
        
        Laptop l1 = new Laptop("HP", "Notebook", 1280, 720, 13.0, 8);
        Laptop l2 = new Laptop("Acer", "Nitro 5", 1920, 1080, 15.3, 16);
        Camera c1 = new Camera("Canon", "XA60", 3840, 2160, 20, true);
        Camera c2 = new Camera("Logitech", "C922", 1920, 1080, null, false);
        Projector p1 = new Projector("Epson", "CO-FH01", 1920, 1080, 0.9, 10.4);
        Projector p2 = new Projector("Optoma", "GT2000HDR",  1920, 1080, 0.3, 3.3);
        
        db.users.Add(e1);
        db.users.Add(e2);
        
        db.equipments.Add(l1);
        db.equipments.Add(l2);
        db.equipments.Add(c1);
        db.equipments.Add(c2);
        db.equipments.Add(p1);
        db.equipments.Add(p2);
        Console.WriteLine(e1.ToString());
        
        Lease lease1 = new Lease(l1, e1, new DateTime(2020, 1, 1), new DateTime(2020, 2, 1), null , 0.20);
        Lease lease2 = new Lease(l2, e1, new DateTime(2026, 3, 15), new DateTime(2026, 3, 30), new DateTime(2026, 3, 30), 0.20);
        Lease lease3 = new Lease(c1, e1, new DateTime(2026, 3, 15), new DateTime(2026, 3, 22), new DateTime(2026, 3, 30),0.20);
        Lease lease4 = new Lease(c2, e1, new DateTime(2025, 3, 15), new DateTime(2026, 3, 22),new DateTime(2026, 3, 19), 0.20);
        Lease lease5 = new Lease(p1, e1, new DateTime(2026, 1, 15), new DateTime(2026, 3, 1), null, 0.20);
        // Lease lease6 = new Lease(p2, e1, new DateTime(2026, 3, 15), new DateTime(2026, 3, 22), 0.20);
        Console.WriteLine(lease1.getPenalty());
        Console.WriteLine(lease2.getPenalty());
        Console.WriteLine(lease3.getPenalty());
        Console.WriteLine(lease4.getPenalty());
        Console.WriteLine(lease5.getPenalty());
        
        Console.WriteLine(e1.ToString());
        Console.WriteLine(db.users[0].ToString());
        db.printCompleteReport();
    }
}