using DeepRockGalactic.Models.Guns.Abstracts;

namespace DeepRockGalactic.Models.Guns.Primaries;

public class LeadStorm : Primary
{
    private const GunType gunType = GunType.HeavyWeapon;
    private const int defaultMaxAmmo = 1200;
    private const int defaultDamage = 10;
    private const int defaultRateOfFirePerSecond = 15;
    private const double defaultSpinUpTimeSeconds = 0.7;
    private const double defaultSpinDownTimeSeconds = 2;
    private const double defaultCoolingRateSeconds = 1.5;
    private const int defaultBulletsPerShot = 2;

    public LeadStorm()
        : base(gunType, defaultMaxAmmo, defaultDamage, defaultRateOfFirePerSecond)
    {
        SpinUpTimeSeconds = defaultSpinUpTimeSeconds;
        SpinDownTimeSeconds = defaultSpinDownTimeSeconds;
        ColingRateSeconds = defaultCoolingRateSeconds;
    }

    public double SpinUpTimeSeconds { get; private set; }
    public double SpinDownTimeSeconds { get; private set; }
    public double ColingRateSeconds { get; private set; }
}
