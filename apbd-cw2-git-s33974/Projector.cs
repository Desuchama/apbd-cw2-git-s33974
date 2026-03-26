namespace apbd_cw2_git_s33974;

public class Projector(string brand, string name, int baseResWidth, int baseResHeight, double minProjectionDist, double maxProjectionDist) : VisualMediaEquipment (brand, name, baseResWidth, baseResHeight)
{
    public double minProjectionDist = minProjectionDist;
    public double maxProjectionDist = maxProjectionDist;
}