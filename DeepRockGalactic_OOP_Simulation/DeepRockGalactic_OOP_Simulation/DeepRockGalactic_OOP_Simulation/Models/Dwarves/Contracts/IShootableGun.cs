using DeepRockGalactic.Models.Contracts;

namespace DeepRockGalactic.Models.Dwarves.Contracts;

public interface IShootableGun
{
    public void ShootPrimary(IHurtable target, int secondsDuration);
    public void ShootSecondary(IHurtable target, int secondsDuration);
}
