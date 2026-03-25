namespace apbd_cw2_git_s33974;

public class Equipment(string name) : Lendable
{
    Guid guid =  Guid.NewGuid();
    public bool available = true;
    public string brandName = name;

    public Guid? LendEquipment()
    {
        if (!available) return null;
        available = false;
        return guid;
    }

    public void ReturnEquipment()
    {
        available = true;
    }
}