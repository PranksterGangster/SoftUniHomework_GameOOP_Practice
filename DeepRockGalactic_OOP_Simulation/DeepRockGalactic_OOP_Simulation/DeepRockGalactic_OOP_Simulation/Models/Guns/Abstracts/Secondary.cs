using DeepRockGalactic.Models.Equipment.Contracts;

namespace DeepRockGalactic.Models.Guns.Abstracts
{
    public class Secondary : NonReloadableGun, ISlottable
    {
        public Secondary(GunType gunType, int maxAmmo, int damage, double rateOfFirePerSecond)
            : base(gunType, maxAmmo, damage, rateOfFirePerSecond)
        {
            Slot = EquipmentSlot.Secondary;
        }

        public EquipmentSlot Slot { get; }
    }
}
