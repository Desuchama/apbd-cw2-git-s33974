namespace apbd_cw2_git_s33974;

public abstract class Equipment(string brand, string name) : Lendable
{
    private static int _nextId = 1;

    public int eqID = _nextId++;
    public bool available = true;
    public string brandName = brand;
    public string eqName = name;
    
    public bool MakeUnavailable()
    {
        if (available)
        {
            available = false;
            return true;
        }
        return false;
    }

    public void MakeAvailable()
    {
        available = true;
    }

    public string ToString()
    {
        return $"Equipment {eqID}: {brandName} {eqName}";
    }
}