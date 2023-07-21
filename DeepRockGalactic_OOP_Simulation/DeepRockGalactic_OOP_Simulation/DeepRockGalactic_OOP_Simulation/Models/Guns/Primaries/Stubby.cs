using DeepRockGalactic.Models.Guns.Abstracts;

namespace DeepRockGalactic.Models.Guns.Primaries;

public class Stubby : ReloadablePrimary
{
    private const GunType gunType = GunType.SubmachineGun;
    private const int defaultMagazineSize = 30;
    private const int defaultMaxAmmo = 30;
    private const double defaultReloadTime = 2;
    private const int defaultDamage = 9;
    private const int defaultRateOfFirePerSecond = 11;

    public Stubby()
        : base(gunType, defaultMaxAmmo, defaultDamage, defaultRateOfFirePerSecond, defaultMagazineSize, defaultReloadTime)
    {
    }
}
