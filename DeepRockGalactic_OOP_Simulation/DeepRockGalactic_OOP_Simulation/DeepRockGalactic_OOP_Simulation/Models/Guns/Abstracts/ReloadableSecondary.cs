using DeepRockGalactic.Models.Guns.Contracts;
using System;

namespace DeepRockGalactic.Models.Guns.Abstracts
{
    public class ReloadableSecondary : Secondary, IReloadable
    {
        public ReloadableSecondary(GunType gunType, int maxAmmo, int damage, double rateOfFirePerSecond, int magazineSize, double reloadTime)
            : base(gunType, maxAmmo, damage, rateOfFirePerSecond)
        {
            MagazineSize = magazineSize;
            ReloadTime = reloadTime;
        }

        public int MagazineSize { get; private set; }

        public double ReloadTime { get; private set; }

        public override int Shoot(int secondsDuration)
        {
            int damageDealt = 0;
            int tempMagazine = MagazineSize;

            for (int i = 0; i < secondsDuration; i++)
            {
                if (MagazineSize <= 0)
                {
                    if (MaxAmmo <= 0)
                    {
                        Console.WriteLine("*click click*");
                        continue;
                    }

                    Console.WriteLine($"*Reloading... ({ReloadTime}s)*");
                    MaxAmmo -= MagazineSize;
                    tempMagazine = MagazineSize;
                }

                damageDealt += (int)RateOfFirePerSecond * secondsDuration * Damage;
                tempMagazine--;
            }

            return damageDealt;
        }
    }
}
