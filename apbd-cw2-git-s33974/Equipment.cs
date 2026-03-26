namespace apbd_cw2_git_s33974;

public abstract class Equipment(string brand, string name, int baseResWidth, int baseResHeight) : Lendable
{
    public Guid eqGuid =  Guid.NewGuid();
    public bool available = true;
    public string brandName = brand;
    public string eqName = name;
    public int baseResWidth = baseResWidth;
    public int baseResHeight = baseResHeight;

    public bool LendEquipment()
    {
        if (available)
        {
            available = false;
            return true;
        }
        return false;
    }

    public void ReturnEquipment()
    {
        available = true;
    }

    public string ToString()
    {
        return brandName + " " + eqName;
    }
}