using DeepRockGalactic.Models.Guns.Abstracts;

namespace DeepRockGalactic.Models.Guns.Secondaries
{
    public class Zhukov : ReloadableSecondary
    {
        private const GunType gunType = GunType.SubmachineGun;
        private const int defaultMagazineSize = 50;
        private const int defaultMaxAmmo = 650;
        private const double defaultReloadTime = 1.8;
        private const int defaultDamage = 12;
        private const int defaultRateOfFirePerSecond = 15;

        public Zhukov()
            : base(gunType, defaultMaxAmmo, defaultDamage, defaultRateOfFirePerSecond, defaultMagazineSize, defaultReloadTime)
        {
        }
    }
}
