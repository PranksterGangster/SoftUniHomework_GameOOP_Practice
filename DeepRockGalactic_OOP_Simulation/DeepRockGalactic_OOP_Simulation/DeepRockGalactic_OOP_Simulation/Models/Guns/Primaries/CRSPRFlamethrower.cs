using DeepRockGalactic.Models.Guns.Abstracts;

namespace DeepRockGalactic.Models.Guns.Primaries;

public class CRSPRFlamethrower : ReloadablePrimary
{
    private const GunType gunType = GunType.HeavyWeapon;
    private const int defaultMaxAmmo = 300;
    private const int defaultMagazineSize = 50;
    private const double defaultReloadTime = 3;
    private const int defaultDamage = 10;
    private const int defaultRateOfFirePerSecond = 6;
    private const double defaultFlameReachMetres = 10;

    public CRSPRFlamethrower()
        : base(gunType, defaultMaxAmmo, defaultDamage, defaultRateOfFirePerSecond, defaultMagazineSize, defaultReloadTime)
    {
        FlameReach = defaultFlameReachMetres;
    }

    public double FlameReach { get; private set; }
}
