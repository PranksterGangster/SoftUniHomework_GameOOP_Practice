using DeepRockGalactic.Models.Guns.Contracts;
using System;

namespace DeepRockGalactic.Models.Guns.Abstracts
{
    public abstract class NonReloadableGun : secondary
    {
        public NonReloadableGun(GunType gunType, int maxAmmo, int damage, double rateOfFirePerSecond)
        {
            GunType = gunType;
            MaxAmmo = maxAmmo;
            Damage = damage;
            RateOfFirePerSecond = rateOfFirePerSecond;
        }

        public GunType GunType { get; }

        public int MaxAmmo { get; protected set; }

        public int Damage { get; private set; }

        public double RateOfFirePerSecond { get; private set; }

        public virtual int Shoot(int secondsDuration)
        {
            int damageDealt = 0;

            for (int i = 0; i < secondsDuration; i++)
            {
                if (MaxAmmo <= 0)
                {
                    Console.WriteLine("*click click*");
                    break;
                }

                damageDealt += (int)RateOfFirePerSecond * secondsDuration * Damage;
                MaxAmmo--;
            }

            return damageDealt;
        }
    }
}
