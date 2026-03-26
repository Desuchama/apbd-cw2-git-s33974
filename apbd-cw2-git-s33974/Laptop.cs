namespace apbd_cw2_git_s33974;

public class Laptop(string brand, string name, int baseResWidth, int baseResHeight, double displaySize, int ramGb) : Equipment (brand, name, baseResWidth, baseResHeight)
{
    public double displaySize = displaySize;
    public double ramGb = ramGb;
}