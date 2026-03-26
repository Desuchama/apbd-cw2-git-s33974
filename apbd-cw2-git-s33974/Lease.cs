using System.Runtime.CompilerServices;

namespace apbd_cw2_git_s33974;

public class Lease()
{   
    public Equipment equipment;
    public User user;
    public DateTime startDate;
    public DateTime endDate;
    public TimeSpan late;
    public double dailyRate;

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
    }

    public double? getPenalty()
    {
        if (late.Days > 0)
            return dailyRate*late.Days;
        else return null;
    }
}