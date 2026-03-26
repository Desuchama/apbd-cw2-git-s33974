namespace apbd_cw2_git_s33974;

public abstract class User(string role, string name, string surname, int allowedLeaseCount)
{
    private static int _nextId = 1;
    
    public int userID = _nextId++;
    public string role = role;
    public string personName = name;
    public string personSurname = surname;
    public int allowedLeaseCount = allowedLeaseCount;
    private int currentLeaseCount = 0;

    public bool addLease()
    {
        if (allowedLeaseCount>currentLeaseCount)
        {
            currentLeaseCount++;
            return true;
        }
        return false;
    }
    public bool removeLease()
    {
        if (currentLeaseCount > 0)
        {
            currentLeaseCount--;
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return role + " GUID: " + userID + " Name: " + personName + " " + personSurname + ", Leases: " + currentLeaseCount + "/" + allowedLeaseCount;
    }
}