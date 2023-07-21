using DeepRockGalactic.Models.Guns.Abstracts;

namespace DeepRockGalactic.Models.Guns.Primaries;

public class M1000Classic : ReloadablePrimary
{
    private const GunType gunType = GunType.SemiAutomaticRifle;
    private const int defaultMagazineSize = 8;
    private const int defaultMaxAmmo = 96;
    private const double defaultReloadTime = 2.5;
    private const int defaultDamage = 55;
    private const int defaultRateOfFirePerSecond = 4;

    public M1000Classic()
        : base(gunType, defaultMaxAmmo, defaultDamage, defaultRateOfFirePerSecond, defaultMagazineSize, defaultReloadTime)
    {
    }
}
