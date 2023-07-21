using DeepRockGalactic.Models.Guns.Abstracts;

namespace DeepRockGalactic.Models.Guns.Secondaries;

public class DeepCore : ReloadableSecondary
{
    private const GunType gunType = GunType.HeavyWeapon;
    private const int defaultMagazineSize = 1;
    private const int defaultMaxAmmo = 9;
    private const double defaultReloadTime = 2;
    private const int defaultDamage = 110;
    private const int defaultRateOfFirePerSecond = 2;
    private const int defaultRadius = 3;

    public DeepCore()
        : base(gunType, defaultMaxAmmo, defaultDamage, defaultRateOfFirePerSecond, defaultMagazineSize, defaultReloadTime)
    {
        Radius = defaultRadius;
    }

    public int Radius { get; private set; }
}
