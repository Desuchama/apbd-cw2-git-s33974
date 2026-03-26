namespace apbd_cw2_git_s33974;

public class User(string name, string surname, int allowedLeaseCount)
{
    public Guid userGuid =  Guid.NewGuid();
    public string personName = name;
    public string personSurname = surname;
    public int allowedLeaseCount = allowedLeaseCount;
}