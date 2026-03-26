namespace apbd_cw2_git_s33974;

public class Camera(string brand, string name, int baseResWidth, int baseResHeight, int? opticalZoom, bool stabilized) : VisualMediaEquipment (brand, name, baseResWidth, baseResHeight)
{
    public int? opticalZoom = opticalZoom;
    public bool stabilized = stabilized;
}