namespace apbd_cw2_git_s33974;

public class Equipment(string brand, string name, int baseResWidth, int baseResHeight) : Lendable
{
    public Guid eqGuid =  Guid.NewGuid();
    public bool available = true;
    public string brandName = brand;
    public string eqName = name;
    public int baseResWidth = baseResWidth;
    public int baseResHeight = baseResHeight;

    public Guid? LendEquipment()
    {
        if (!available) return null;
        available = false;
        return eqGuid;
    }

    public void ReturnEquipment()
    {
        available = true;
    }
}