namespace apbd_cw2_git_s33974;

public abstract class VisualMediaEquipment(string brand, string name, int baseResWidth, int baseResHeight) : Equipment(brand, name)
{
    public int baseResWidth = baseResWidth;
    public int baseResHeight = baseResHeight;
}