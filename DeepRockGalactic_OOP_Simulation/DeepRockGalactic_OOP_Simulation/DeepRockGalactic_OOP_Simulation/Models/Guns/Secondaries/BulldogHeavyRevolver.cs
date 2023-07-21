using DeepRockGalactic.Models.Guns.Abstracts;

namespace DeepRockGalactic.Models.Guns.Secondaries;

public class BulldogHeavyRevolver : ReloadableSecondary
{
    private const GunType gunType = GunType.Revolver;
    private const int defaultMagazineSize = 4;
    private const int defaultMaxAmmo = 24;
    private const double defaultReloadTime = 2;
    private const int defaultDamage = 60;
    private const int defaultRateOfFirePerSecond = 2;

    public BulldogHeavyRevolver()
        : base(gunType, defaultMaxAmmo, defaultDamage, defaultRateOfFirePerSecond, defaultMagazineSize, defaultReloadTime)
    {
    }
}
