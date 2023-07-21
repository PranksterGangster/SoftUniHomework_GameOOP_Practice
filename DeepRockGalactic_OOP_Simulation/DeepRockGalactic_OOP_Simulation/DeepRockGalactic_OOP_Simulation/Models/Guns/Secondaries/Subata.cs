using DeepRockGalactic.Models.Guns.Abstracts;

namespace DeepRockGalactic.Models.Guns.Secondaries;

public class Subata : ReloadableSecondary
{
    private const GunType gunType = GunType.Pistol;
    private const int defaultMagazineSize = 12;
    private const int defaultMaxAmmo = 160;
    private const double defaultReloadTime = 1.9;
    private const int defaultDamage = 12;
    private const int defaultRateOfFirePerSecond = 8;

    public Subata()
        : base(gunType, defaultMaxAmmo, defaultDamage, defaultRateOfFirePerSecond, defaultMagazineSize, defaultReloadTime)
    {
    }
}
