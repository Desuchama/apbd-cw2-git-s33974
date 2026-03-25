namespace apbd_cw2_git_s33974;

public interface Lendable
{
    Guid? LendEquipment();
    void ReturnEquipment();
}