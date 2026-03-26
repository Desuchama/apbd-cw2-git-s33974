using System.Runtime.CompilerServices;

namespace apbd_cw2_git_s33974;

public class Lease()
{   
    private static int _nextId = 1;

    public int leaseID = _nextId++;
    public Equipment equipment;
    public User user;
    public DateTime startDate;
    public DateTime endDate;
    public TimeSpan late;
    public double dailyRate;
    public int? lateDays;

    public Lease(Equipment eq, User us, DateTime startDate, DateTime endDate, double dailyRate) : this()
    {
        if (eq.available && us.addLease())
        {
            this.user = us;
            this.equipment = eq;
        }
        else throw new Exception("Equipment unavailable or lease limit reached");
        this.startDate = startDate; 
        this.endDate = endDate;
        this.late = DateTime.Now - endDate;
        this.dailyRate = dailyRate;
        this.lateDays = late.Days > 0 ? late.Days : 0;
    }

    public double? getPenalty()
    {
        if (lateDays > 0)
            return dailyRate*lateDays;
        else return null;
    }

    public override string ToString()
    {
        return $"{equipment.brandName} {equipment.eqName} leased by {user.ToString()} on {startDate}; {lateDays} days late.";
    }
}