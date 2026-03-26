using System.Runtime.CompilerServices;

namespace apbd_cw2_git_s33974;

public class Lease()
{   
    private static int _nextId = 1;

    public int leaseID = _nextId++;
    public Equipment equipment;
    public User user;
    public DateTime startDate;
    public DateTime? endDate;
    public DateTime deadLine;
    public TimeSpan late;
    public double dailyRate;
    public int lateDays;

    public Lease(Equipment eq, User us, DateTime startDate, DateTime deadLine, DateTime? endDate, double dailyRate) : this()
    {
        this.user = us;
        this.equipment = eq;
        //else throw new Exception("Equipment unavailable or lease limit reached");
        this.startDate = startDate; 
        this.endDate = endDate;
        this.late = (endDate ?? DateTime.Now) - deadLine;
        this.dailyRate = dailyRate;
        this.lateDays = late.Days > 0 ? late.Days : 0;
        if (endDate != null)
            eq.MakeUnavailable();
    }

    public double getPenalty()
    {
        if (lateDays > 0)
            return dailyRate*lateDays;
        else return 0;
    }
    public void SetEndDate(DateTime endDate)
    {
        this.endDate = endDate;
    }
    
    public override string ToString()
    {
        return $"{equipment.brandName} {equipment.eqName} leased by {user.ToString()} on {startDate}; {lateDays} days late.";
    }
}